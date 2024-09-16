using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class BodyWorkRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public BodyWorkRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BodyworkEntity>> Get()
        {
            return await _dbContext.Bodyworks
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<BodyworkEntity?> GetById(Guid id)
        {
            return await _dbContext.Bodyworks
                .AsNoTracking()
                .FirstOrDefaultAsync(bd => bd.Id == id);
        }

        public async Task<int> Add(Guid Id, string name)
        {

            BodyworkEntity bodyWork = new()
            {
                Id = Id,
                Name = name
            };

            await _dbContext.AddAsync(bodyWork);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name)
        {
            return await _dbContext.Bodyworks
                .Where(bw => bw.Id == Id)
                .ExecuteUpdateAsync(bw => bw
                    .SetProperty(bw => bw.Name, name));
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.Bodyworks
                .Where(bw => bw.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
