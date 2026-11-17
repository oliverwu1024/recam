using Recam.Models.Enums;

namespace Recam.Models.Entities;

public class ListingCase
{
    public int Id { get; set; }

    public required string Title {get; set;}
    public required string Description {get; set;}
    public required string Street {get; set;}
    public required string City {get; set;}
    public required string State {get; set;}
    public required int Postcode {get; set;}
    public decimal? Longitude {get; set;}
    public decimal? Latitude {get; set;}
    public required double Price {get; set;}
    public required int Bedrooms {get; set;}
    public required int Bathrooms {get; set;}
    public int? Garages {get; set;}
    public required double FloorArea {get; set;}
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public bool IsDeleted {get; set;}

    public required PropertyType PropertyType {get; set;}
    public required SaleCategory SaleCategory {get; set;}

    public ListcaseStatus ListcaseStatus {get; set;} = ListcaseStatus.Created;
    public required string UserId {get; set;}

    public ICollection<CaseContact> CaseContacts {get; set;} = new List<CaseContact>();
    public ICollection<MediaAsset> MediaAssets {get; set;} = new List<MediaAsset>();
    public User User {get; set;} = null!;
    public ICollection<AgentListingCase> AgentListingCases {get; set;} = new List<AgentListingCase>();

}
