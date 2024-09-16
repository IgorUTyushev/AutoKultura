
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class VechicleRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public VechicleRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<List<VechicleEntity>> Get()
        {
            return await _dbContext.Vechicles
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<ViewVechicleForOrder> GetByOrderId(Guid orderId)
        {
#pragma warning disable CS8603, CS8602 // Возможно, возврат ссылки, допускающей значение NULL.
            return await _dbContext.Orders
               .AsNoTracking()
               .Where(o => o.Id == orderId)
               .Include(o => o.Vechicle)
                    .ThenInclude(v => v.ModelCar)
                        .ThenInclude(m => m.BrandCar)               
               .Select(str => new ViewVechicleForOrder
               {
                   IdVechicle = str.Vechicle.Id,
                   BrandCar = str.Vechicle.ModelCar.BrandCar,
                   Model = str.Vechicle.ModelCar,
                   RegisterNumber = str.Vechicle.RegisterNumberCar
               })
               .FirstOrDefaultAsync();
#pragma warning restore CS8603, CS8602 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        public async Task<int> Add(Guid Id,Guid customerId, Guid modelCarId, string registerNumber)
        {

            VechicleEntity company = new ()
            {
                Id = Id,
                CustomerId = customerId,
                ModelCarId = modelCarId,
                RegisterNumberCar = registerNumber
            };

            await _dbContext.AddAsync(company);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, Guid modelCarId, string registerNumber)
        {
            return await _dbContext.Vechicles
                .Where(v => v.Id == Id)
                .ExecuteUpdateAsync(v => v
                    .SetProperty(v => v.ModelCarId, modelCarId)
                    .SetProperty(v => v.RegisterNumberCar, registerNumber));
        }

        //public async Task Delete(Guid Id)
        //{
        //    await _dbContext.Company
        //        .Where(c => c.Id == Id)
        //        .ExecuteDeleteAsync();
        //}
    }
}
