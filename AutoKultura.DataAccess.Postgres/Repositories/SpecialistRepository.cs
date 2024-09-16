
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class SpecialistRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public SpecialistRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SpecialistEntity>> Get()
        {
            return await _dbContext.Specialists
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> Add(Guid Id, string name, string phone)
        {

            SpecialistEntity specialist = new()
            {
                Id = Id,
                Name = name,
                Phone = phone,
            };

            await _dbContext.AddAsync(specialist);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, string phone)
        {
            return await _dbContext.Specialists
                .Where(s => s.Id == Id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(s => s.Name, name)
                    .SetProperty(s => s.Phone, phone));
        }

        public async Task Delete(Guid Id)
        {
             await _dbContext.Specialists
                .Where(s => s.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
