namespace Recam.Models.Entities;

public class AgentPhotographyCompany
{
    public required string AgentId {get; set;}
    public required string PhotographyCompanyId {get; set;}

    public Agent Agent {get; set;} = null!;
    public PhotographyCompany PhotographyCompany {get; set;} = null!;
}
