
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class MaterialRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public MaterialRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<List<ViewMaterial>> Get()
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            return await _dbContext.Materials
                .AsNoTracking()
                .Include(material => material.MeasureUnit)
                .Include(material => material.HistoryOfTheChangesPriceMaterials)
                .Select(str => new ViewMaterial
                {
                    IdMaterial = str.Id,
                    IdMeasureUnite = str.MeasureUnitId,
                    NameMaterial = str.Name,
                    NameMeasureUnit = str.MeasureUnit.Name,
                    Price = str.HistoryOfTheChangesPriceMaterials.OrderByDescending(items => items.DateChange).First().Price,
                    Count = str.Count
                })
                .ToListAsync();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        public async Task<int> Add(Guid Id, string name, MeasureUnitEntity measureUnit, decimal price, decimal count)
        {

            MaterialEntity material = new()
            {
                Id = Id,
                Name = name,
                MeasureUnitId = measureUnit.Id,
                Count = count
            };

            await _dbContext.AddAsync(material);

            HistoryOfTheChangePriceMaterialEntity priceHistory = new()
            {
                Id = Guid.NewGuid(),
                DateChange = DateTime.UtcNow,
                MaterialId = Id,
                Price = price
            };
            await _dbContext.AddAsync(priceHistory);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, MeasureUnitEntity measureUnit, decimal price, decimal count)
        {

            await _dbContext.Materials
                .Where(m => m.Id == Id)
                .ExecuteUpdateAsync(m => m
                    .SetProperty(m => m.Name, name)
                    .SetProperty(m => m.MeasureUnitId, measureUnit.Id)
                    .SetProperty(m => m.Count, count));


            HistoryOfTheChangePriceMaterialEntity priceHistory = new()
            {
                Id = Guid.NewGuid(),
                DateChange = DateTime.UtcNow,
                MaterialId = Id,
                Price = price                
            };
            await _dbContext.AddAsync(priceHistory);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(Guid Id)
        {
            _dbContext.HistoryOfTheChangePriceMaterials
                .Where(h => h.MaterialId == Id);

            await _dbContext.Materials
                .Where(m => m.Id == Id)
                .ExecuteDeleteAsync();

            return await _dbContext.SaveChangesAsync();
        }
    }
}
