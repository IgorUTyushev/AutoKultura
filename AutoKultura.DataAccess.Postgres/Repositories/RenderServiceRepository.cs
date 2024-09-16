
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class RenderServiceRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public RenderServiceRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<List<ViewRenderService>> Get()
        {
            return await _dbContext.RendersServices
                .AsNoTracking()
                .Include(rs => rs.PartOfTheCar)
                    .ThenInclude(pc => pc.ServiceType)
                .Select(str => new ViewRenderService
                {
                    Id = str.Id,
                    NameServiceType = str.PartOfTheCar.ServiceType.Title,
                    PartOfTheCar = str.PartOfTheCar.Name,
                    IdOrder = str.OrderId,
                    Price = str.Price,
                })
                .ToListAsync();
        }
        public async Task<List<ViewRenderService>> GetByIdOrder(Guid orderId)
        {
            return await _dbContext.RendersServices
                .AsNoTracking()
                .Include(rs => rs.PartOfTheCar)
                    .ThenInclude(pc => pc.ServiceType)
                .Where(rs => rs.OrderId == orderId).
                Select(str => new ViewRenderService
                {
                    Id = str.Id,
                    NameServiceType = str.PartOfTheCar.ServiceType.Title,
                    PartOfTheCar = str.PartOfTheCar.Name,
                    IdOrder = str.OrderId,
                    Price = str.Price,
                })
                .ToListAsync();
        }

        public async Task<int> Add(Guid id, Guid orderId, Guid partOfTheCarId, decimal price)
        {

            RenderServiceEntity renderService = new()
            {
                Id = id,
                OrderId = orderId,
                PartOfTheCarId = partOfTheCarId,
                Price = price
            };

            await _dbContext.AddAsync(renderService);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.RendersServices
               .Where(rs => rs.Id == Id)
               .ExecuteDeleteAsync();
        }        
    }
}
