
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class UsedUpMaterialRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        public async Task<List<ViewUsedUpMaterial>> GetByIdRenderServices( Guid renderServicesId)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            return await _dbContext.UsedUpMaterials
                .AsNoTracking()
                .Where(rs => rs.RenderServiceId == renderServicesId)
                .Include(rs => rs.Material)
                    .ThenInclude(material=> material.MeasureUnit)
                .Select(str => new ViewUsedUpMaterial
                {
                    IdUsedUpMaterial = str.Id,
                    NameMaterial = str.Material.Name,
                    Quantity = str.QuantityMaterial,
                    NameMeasureUnit = str.Material.MeasureUnit.Name
                })
                .ToListAsync();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }

        public async Task<int> Add(Guid Id, Guid materialId, Guid renderServiceId, decimal quantityUsedMaterial)
        {

            UsedUpMaterialEntity usedMaterial = new()
            {
                Id = Id,
                MaterialId = materialId,
                RenderServiceId = renderServiceId,
                QuantityMaterial = quantityUsedMaterial
            };

            await _dbContext.AddAsync(usedMaterial);         

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(Guid Id)
        {

            await _dbContext.UsedUpMaterials
                .Where(um => um.Id == Id)
                .ExecuteDeleteAsync();

            return await _dbContext.SaveChangesAsync();
        }
    }
}
