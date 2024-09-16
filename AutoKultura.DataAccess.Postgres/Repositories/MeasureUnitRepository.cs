
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class MeasureUnitRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public MeasureUnitRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MeasureUnitEntity>> Get()
        {
            return await _dbContext.MeasureUnits
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<MeasureUnitEntity?> GetById(Guid id)
        {
            return await _dbContext.MeasureUnits
                .AsNoTracking()
                .FirstOrDefaultAsync(mu => mu.Id == id);
        }

        public async Task<int> Add(Guid Id, string name)
        {

            MeasureUnitEntity measureUnit = new()
            {
                Id = Id,
                Name = name
            };

            await _dbContext.AddAsync(measureUnit);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name)
        {      
            return await _dbContext.MeasureUnits
                .Where(m => m.Id == Id)
                .ExecuteUpdateAsync(m => m
                    .SetProperty(m => m.Name, name));
        }

        public async Task<int> Delete(Guid Id)
        {
            return await _dbContext.MeasureUnits
                .Where(m => m.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
