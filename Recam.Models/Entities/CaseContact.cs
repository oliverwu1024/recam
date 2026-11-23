using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace Recam.Models.Entities;

public class CaseContact
{   
    public int ContactId {get; set;}
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? CompanyName { get; set; }
    public string? ProfileUrl { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required int ListingCaseId {get; set;}
    public ListingCase ListingCase {get; set;} = null!;

}
