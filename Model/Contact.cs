using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MainFarm.Model;

public class Contact : MainFarmBase
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FullName => $@"{FirstName} {LastName}";
    public string? Code { get; set; }

    [Display(Name = "Date of Birth")]
    public DateTime? Dob { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Guid? OwnedBy { get; set; }
    public Guid? GenderGuid { get; set; }
    public string? Address { get; set; }
    [Url]
    public string? Website { get; set; }
    public Guid? LocationGuid { get; set; }
    [ForeignKey("LocationGuid")]
    public virtual Location? Location { get; set; }
}
