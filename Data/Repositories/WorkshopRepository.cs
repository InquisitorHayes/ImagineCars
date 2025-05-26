using ImagineCars.Data.Dbo;
using ImagineCars.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace ImagineCars.Data.Repositories;

public class WorkshopRepository : IWorkshopRepository
{
    private readonly IDbContextFactory<ImagineCarsDbContext> _dbContextFactory;

    public WorkshopRepository(IDbContextFactory<ImagineCarsDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<IEnumerable<Workshop>> GetAllWorkshopsForCompany(Guid CompanyId)
    {
        using var dbContext = _dbContextFactory.CreateDbContext();
        var results = await dbContext.Workshops.Where((w => 
                w.CompanyId == CompanyId)).ToListAsync();

        if (!results.Any())
        {
            return null;
        }

        return results;
    }

    public async Task<Workshop> AddWorkshopToCompany(Guid CompanyId)
    {
        //TODO: Implement me!
        return null;
    }
}

