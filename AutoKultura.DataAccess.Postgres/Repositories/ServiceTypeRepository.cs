
using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class ServiceTypeRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;

        //public ServiceTypeRepository(AutoKulturaDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public async Task<List<ServiceTypeEntity>> Get()
        {
            return await _dbContext.ServicesTypes
                .AsNoTracking()                
                .ToListAsync();
        }

        public async Task<ServiceTypeEntity?> GetById(Guid serviceTypeId)
        {
            return await _dbContext.ServicesTypes
                .AsNoTracking()
                .Where(st => st.Id == serviceTypeId)
                .FirstOrDefaultAsync();
        }

        public async Task<int> Add(Guid Id, string tite)
        {

            ServiceTypeEntity serviceType = new()
            {
                Id = Id,
                Title = tite
            };

            await _dbContext.AddAsync(serviceType);

            return await _dbContext.SaveChangesAsync();
        }



        public async Task<int> Update(Guid Id, string tite)
        {

            await _dbContext.ServicesTypes
                 .Where(st => st.Id == Id)
                 .ExecuteUpdateAsync(st => st
                     .SetProperty(st => st.Title, tite));

            return await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.ServicesTypes
                .Where(st => st.Id == Id)
                .ExecuteDeleteAsync();         
        }
    }
}
