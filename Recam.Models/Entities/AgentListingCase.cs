using System.Diagnostics.Contracts;

namespace Recam.Models.Entities;

public class AgentListingCase
{
    public required string AgentId {get; set;}
    public required int ListingCaseId {get; set;}

    public Agent Agent {get; set;} = null!;
    public ListingCase ListingCase {get; set;} = null!;

}
