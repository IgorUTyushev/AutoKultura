
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class PartOfTheCarRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public ServiceTypeRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<List<ViewPartOfTheCar>> Get()
        {
            return await _dbContext.PartsOfTheCar
                .AsNoTracking()
                .Include(pc => pc.ServiceType)
                .Include(pc => pc.HistoryOfTheChangesPriceServicesTypePartOfTheCar)
                .Select(str => new ViewPartOfTheCar
                {
                    Id = str.Id,
                    NamePartOfTheCar = str.Name,
                    ServiseTypeId = str.ServiceType.Id,
                    NameServiceType = str.ServiceType.Title,
                    Price = str.HistoryOfTheChangesPriceServicesTypePartOfTheCar.OrderByDescending(items => items.DateChange).First().Price
                }
                    )
                .ToListAsync();
        }

        public async Task<List<ViewPartOfTheCar>> GetByIdServiceType(Guid serviceTypeId)
        {
            return await _dbContext.PartsOfTheCar
                .AsNoTracking()
                .Where(pc => pc.ServiceTypeId == serviceTypeId)
                .Include(pc => pc.ServiceType)
                .Include(pc => pc.HistoryOfTheChangesPriceServicesTypePartOfTheCar)
                .Select(str => new ViewPartOfTheCar
                {
                    Id = str.Id,
                    NamePartOfTheCar = str.Name,
                    ServiseTypeId = str.ServiceType.Id,
                    NameServiceType = str.ServiceType.Title,
                    Price = str.HistoryOfTheChangesPriceServicesTypePartOfTheCar.OrderByDescending(items => items.DateChange).First().Price
                }
                    )
                .ToListAsync();
        }

        public async Task<int> Add(Guid Id, string name, Guid serviceTypeId, decimal price)
        {

            PartOfTheCarEntity serviceType = new()
            {
                Id = Id,
                Name = name,
                ServiceTypeId = serviceTypeId                
            };

            await _dbContext.AddAsync(serviceType);

            HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity priceHistory = new()
            {
                Id = Guid.NewGuid(),
                DateChange = DateTime.UtcNow,
                PartOfTheCarId = Id,
                Price = price
            };
            await _dbContext.AddAsync(priceHistory);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, Guid serviceTypeId, decimal price)
        {

            await _dbContext.PartsOfTheCar
                 .Where(st => st.Id == Id)
                 .ExecuteUpdateAsync(st => st
                     .SetProperty(st => st.Name, name)
                     .SetProperty(st => st.ServiceTypeId, serviceTypeId));

            HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity priceHistory = new()
            {
                Id = Guid.NewGuid(),
                DateChange = DateTime.UtcNow,
                PartOfTheCarId = Id,
                Price = price
            };
            await _dbContext.AddAsync(priceHistory);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.HistoryOfTheChangePriceServicesPartCar
                .Where(h => h.PartOfTheCarId == Id)
                .ExecuteDeleteAsync();

            await _dbContext.PartsOfTheCar
                .Where(st => st.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
