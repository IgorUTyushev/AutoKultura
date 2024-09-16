
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class PymentMethodRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public PymentMethodRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<PymentMethodEntity>> Get()
        {
            return await _dbContext.PymentMethods
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<PymentMethodEntity?> GetById(Guid id)
        {
            return await _dbContext.PymentMethods
                .AsNoTracking()
                .FirstOrDefaultAsync(mu => mu.Id == id);
        }

        public async Task<int> Add(Guid Id, string name, bool defaultMethod)
        {

            PymentMethodEntity pymentMethod = new()
            {
                Id = Id,
                Name = name,
                MethodDefault = defaultMethod
            };

            await _dbContext.AddAsync(pymentMethod);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, bool methodDefault)
        {
            if (methodDefault)
                _dbContext.PymentMethods
                    .ExecuteUpdate(pm => pm
                        .SetProperty(pm => pm.MethodDefault, false));

            return await _dbContext.PymentMethods
                .Where(m => m.Id == Id)
                .ExecuteUpdateAsync(m => m
                    .SetProperty(m => m.Name, name)
                    .SetProperty(m => m.MethodDefault, methodDefault));
        }

        public async Task<int> Delete(Guid Id)
        {
            return await _dbContext.PymentMethods
                .Where(m => m.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
