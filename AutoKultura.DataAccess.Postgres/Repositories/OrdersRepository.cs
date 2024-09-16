
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class OrdersRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public OrdersRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<OrderEntity> GetById(Guid id)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return await _dbContext.Orders
                .AsNoTracking()
                .Where (o => o.Id == id)
                .FirstOrDefaultAsync();
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        public async Task<List<ViewOrders>> GetViewOrders()
        {
            return await _dbContext.Orders
                .AsNoTracking()
                .Include(orders => orders.Vechicle)
                    .ThenInclude(vechicle => vechicle.Customer)
                .Include(orders => orders.Vechicle)
                    .ThenInclude(vechicle => vechicle.ModelCar)
                    .ThenInclude(modelCar => modelCar.BrandCar)
                .Select(str => new ViewOrders
                {
                    Id = str.Id,
                    DateOrder = str.DateOrder,
                    NameBrandCar = str.Vechicle.ModelCar.BrandCar.Name,
                    NameModelCar = str.Vechicle.ModelCar.Name,
                    NameCustomer = str.Vechicle.Customer.Name,
                    DateOfDeliveryOfTheOrder = str.DateOfDeliveryOfTheOrder,
                    RegisterNumber = str.Vechicle.RegisterNumberCar
                })
                .ToListAsync();
        }

        public async Task<int> Add(Guid id, DateTime dateOrder, Guid vechicleId, Guid pymentMethodId)
        {

            OrderEntity order = new()
            {
                Id = id,
                DateOrder = dateOrder,
                VechicleId = vechicleId,
                PymentMethodId = pymentMethodId
            };

            await _dbContext.AddAsync(order);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, Guid vechicleId, DateTime dateOrder,
            DateTime dateOfDeliveryOfTheOrder, decimal price, Guid pymentMethodId)
        {

            return await _dbContext.Orders
                .Where(order => order.Id == Id)
                .ExecuteUpdateAsync(order => order
                    .SetProperty(order => order.DateOrder, dateOrder)
                    .SetProperty(order => order.VechicleId, vechicleId )
                    .SetProperty(order => order.DateOfDeliveryOfTheOrder, dateOfDeliveryOfTheOrder)
                    .SetProperty(order => order.Price, price)
                    .SetProperty(order => order.PymentMethodId, pymentMethodId));
        }

        public async Task<int> Delete(Guid Id)
        {
            OrderEntity order = _dbContext.Orders
                .Include(order => order.Vechicle)
                .First(o => o.Id == Id);
            
            await _dbContext.Vechicles
                .Where(vechicle => vechicle.Id == order.Vechicle.Id)
                .ExecuteDeleteAsync();

            int result = await _dbContext.Orders
                .Where(h => h.Id == Id)
                .ExecuteDeleteAsync();



            return result;
        }
    }
}
