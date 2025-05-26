using System.ComponentModel.DataAnnotations;

namespace ImagineCars.Data.Dbo;

public class Workshop
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Guid CompanyId { get; set; }
}

