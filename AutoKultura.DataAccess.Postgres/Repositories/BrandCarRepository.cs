using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class BrandCarRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public BrandCarRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BrandCarEntity>> Get()
        {
            return await _dbContext.BrandsCars
                .AsNoTracking()               
                .ToListAsync();
        }

        public async Task<BrandCarEntity?> GetById(Guid id)
        {
            return await _dbContext.BrandsCars
                .AsNoTracking()
                .FirstOrDefaultAsync(bc => bc.Id == id);
        }

        public async Task<int> Add(Guid Id, string name)
        {

            BrandCarEntity serviceType = new()
            {
                Id = Id,
                Name = name
            };

            await _dbContext.AddAsync(serviceType);           

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name)
        {
            return await _dbContext.BrandsCars
                .Where(bc => bc.Id == Id)
                .ExecuteUpdateAsync(bc => bc
                    .SetProperty(bc => bc.Name, name));
        }
        public async Task Delete(Guid Id)
        {
            await _dbContext.BrandsCars
                .Where(bc => bc.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
