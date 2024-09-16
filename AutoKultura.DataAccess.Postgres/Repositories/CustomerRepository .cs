
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class CustomerRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public CustomerRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CustomerEntity>> Get()
        {
            return await _dbContext.Customers
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<CustomerEntity> GetByOrderId(Guid id)
        {
#pragma warning disable CS8603, CS8602 // Возможно, возврат ссылки, допускающей значение NULL.
            var result = await _dbContext.Orders
                .AsNoTracking()                
                .Where(o => o.Id == id)
                .Include(O => O.Vechicle)
                .FirstOrDefaultAsync();

            return await _dbContext.Customers
                .Where(c => c.Id == result.Vechicle.CustomerId)
                .AsNoTracking()
                .FirstOrDefaultAsync();
#pragma warning restore CS8603, CS8602 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        public async Task<int> Add(Guid Id,string name, string phone, string email, string additionalInformation)
        {

            CustomerEntity customer = new ()
            {
                Id = Id,
                Name = name,
                Phone = phone,
                Email = email,
                AdditionalInformation = additionalInformation
            };

            await _dbContext.AddAsync(customer);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, string phone, string email, string additionalInformation)
        {
            return await _dbContext.Customers
                .Where(c => c.Id == Id)
                .ExecuteUpdateAsync(c => c
                    .SetProperty(c => c.Name, name)
                    .SetProperty(c => c.Phone, phone)
                    .SetProperty(c => c.Email, email)
                    .SetProperty(c => c.AdditionalInformation, additionalInformation));
        }

        //public async Task Delete(Guid Id)
        //{
        //    await _dbContext.Company
        //        .Where(c => c.Id == Id)
        //        .ExecuteDeleteAsync();
        //}
    }
}
