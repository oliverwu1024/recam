

namespace Recam.Models.Entities;

public class Agent 
{
    public required string Id { get; set; } 
    public required string AgentFirstName { get; set; }
    public required string AgentLastName { get; set; }
    public string? AvatarUrl { get; set; }

    public required string CompanyName { get; set; }

    public User User { get; set; } = null!;

    public ICollection<AgentListingCase> AgentListingCases {get; set;} = new List<AgentListingCase>();
    public ICollection<AgentPhotographyCompany> AgentPhotographyCompanies {get; set;} = new List<AgentPhotographyCompany>();

}
