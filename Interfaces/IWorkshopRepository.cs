using ImagineCars.Data.Dbo;
namespace ImagineCars.Interfaces;

public interface IWorkshopRepository
{
    Task<IEnumerable<Workshop>> GetAllWorkshopsForCompany(Guid CompanyId);
    Task<Workshop> AddWorkshopToCompany(Guid CompanyId);
}