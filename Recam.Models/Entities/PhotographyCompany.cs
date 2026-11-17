namespace Recam.Models.Entities;

public class PhotographyCompany
{
    public required string Id { get; set; }
    public required string PhotographyCompanyName { get; set; }

    public User User { get; set; } = null!;
    public ICollection<AgentPhotographyCompany> agentPhotographyCompanies {get; set;} = new List<AgentPhotographyCompany>();
}
