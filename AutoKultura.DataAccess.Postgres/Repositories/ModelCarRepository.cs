
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class ModelCarRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public ModelCarRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ViewModelCar>> Get()
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            return await _dbContext.ModelsCars
                .AsNoTracking()
                .Include(modelCar => modelCar.BrandCar)
                .Include(modelCar => modelCar.Bodywork)
                .Select(str => new ViewModelCar
                {
                    IdModelCar = str.Id,
                    NameModelCar = str.Name,
                    NameBrandCar = str.BrandCar.Name,
                    NameBodyWork = str.Bodywork.Name,
                    IdBodyWork = str.Bodywork.Id,
                    IdBrandCar = str.BrandCarId
                })
                .ToListAsync();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }
        public List<ModelCarEntity> GetByIdBrandCar(Guid brandCarId)
        {
            return _dbContext.ModelsCars
                .AsNoTracking()
                .Where(m => m.BrandCarId == brandCarId)
                .ToList();
        }

        public async Task<int> Add(Guid Id, string name, BrandCarEntity brandCar, BodyworkEntity bodyWork)
        {

            ModelCarEntity modelCar = new()
            {
                Id = Id,
                Name = name,
                BodyworkId = bodyWork.Id,
                BrandCarId = brandCar.Id
            };

            await _dbContext.AddAsync(modelCar);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.ModelsCars
               .Where(m => m.Id == Id)
               .ExecuteDeleteAsync();
        }

        public async Task<int> Update(Guid Id, string name, BrandCarEntity brandCar, BodyworkEntity bodyWork)
        {
            return await _dbContext.ModelsCars
               .Where(m => m.Id == Id)
               .ExecuteUpdateAsync(m => m
                   .SetProperty(m => m.Name, name)
                   .SetProperty(m => m.BrandCarId, brandCar.Id)
                   .SetProperty(m => m.BodyworkId, bodyWork.Id));
        }
    }
}
