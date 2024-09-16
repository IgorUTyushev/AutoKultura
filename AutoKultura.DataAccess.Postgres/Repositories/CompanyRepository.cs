
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKultura.DataAccess.SqlServer.Repositories
{
    public class CompanyRepository
    {
        private readonly AutoKulturaDbContext _dbContext;

        public CompanyRepository(AutoKulturaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CompanyEntity>> Get()
        {
            return await _dbContext.Company
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<int> Add(Guid Id,string name, string phone, string email, string adress, int numberOrderOnOutfit, string pathToFilesOrderOnOutfit)
        {

            CompanyEntity company = new ()
            {
                Id = Id,
                Name = name,
                Phone = phone,
                Email = email,
                Adress = adress,
                NumberOrderOnOutfit = numberOrderOnOutfit,
                PathToFilesOrderOnOutfit = pathToFilesOrderOnOutfit 
            };

            await _dbContext.AddAsync(company);

            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(Guid Id, string name, string phone, string email, string adress, int numberOrderOnOutfit, string pathToFilesOrderOnOutfit)
        {
            return await _dbContext.Company
                .Where(c => c.Id == Id)
                .ExecuteUpdateAsync(c => c
                    .SetProperty(c => c.Name, name)
                    .SetProperty(c => c.Phone, phone)
                    .SetProperty(c => c.Email, email)
                    .SetProperty(c => c.Adress, adress)
                    .SetProperty(c => c.NumberOrderOnOutfit, numberOrderOnOutfit)
                    .SetProperty(c => c.PathToFilesOrderOnOutfit, pathToFilesOrderOnOutfit));
        }

        public async Task Delete(Guid Id)
        {
            await _dbContext.Company
                .Where(c => c.Id == Id)
                .ExecuteDeleteAsync();
        }
    }
}
