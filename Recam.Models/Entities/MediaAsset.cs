using Recam.Models.Enums;

namespace Recam.Models.Entities;

public class MediaAsset
{
    public int Id {get; set;}
    public required MediaType MediaType {get;set;}

    public required string MediaUrl {get;set;}
    public DateTime UploadedAt {get; set;} = DateTime.UtcNow;

    public bool IsSelect {get; set;}

    public bool IsHero {get; set;}

    public required int ListingCaseId {get; set;}

    public required string UserId {get; set;}

    public bool IsDeleted {get; set;}

    public ListingCase ListingCase {get; set;} = null!;
    public User User {get; set;} = null!;
}
