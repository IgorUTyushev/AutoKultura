using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class LinqSpecialistForRenderServiceslRepository(AutoKulturaDbContext dbContext)
    {
        private readonly AutoKulturaDbContext _dbContext = dbContext;        

        public async Task<int> Add(Guid Id, Guid SpecialistId, Guid RenderServicesId)
        {

            LinqSpecialistForRenderServicesEntity linqSForR = new()
            {
                Id = Id,
                SpecialistId = SpecialistId,
                RenderServiceId = RenderServicesId
            };

            await _dbContext.AddAsync(linqSForR);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(Guid SpecialistId, Guid RenderServicesId )
        {
            await _dbContext.LinqSpecialistForRenderServices
                .Where(l => l.SpecialistId == SpecialistId)
                .Where(l => l.RenderServiceId == RenderServicesId)
                .ExecuteDeleteAsync();

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<SpecialistEntity>> GetSpecialistByIdRenderServices(Guid renderServicesId)
        {
            return await _dbContext.LinqSpecialistForRenderServices
                .AsNoTracking()
                .Where(l => l.RenderServiceId == renderServicesId)
                    .Include(l => l.Specialist)
                .Select(str => new SpecialistEntity
                {
                    Id = str.Specialist.Id,
                    Name = str.Specialist.Name,
                    Phone = str.Specialist.Phone
                })
                .ToListAsync();
        }
    }
}
