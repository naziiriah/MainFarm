using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using MainFarm.Enums;

namespace MainFarm.Model;

public class FarmSection : MainFarmBase
{
    public string SectionName { get; set; } = "";

    public eGrowthStage Stage { get; set; }

    public int NumberOfBirds {  get; set; }

    public eBirdType BirdType { get; set;}

    public string Genome { get; set; } = "";

    public int DailyFeedConsumption { get; set; }

    public bool IsSick {  get; set; }

    public bool IsSold { get; set; }
 
    public ICollection<EggRecord>? EggRecords {  get; set; }

    public DateTime DateOfBooking { get; set; }

    public DateTime DateOfCollection { get; set; }

    [ForeignKey("FarmGuid")]
    public Guid FarmGuid {  get; set; }

    public Farm? Farm { get; set; }

    public int WeeksOld()
    {
        TimeSpan timeSinceTarget = DateTime.Now - DateOfBooking;
        int weeksAgo = (int)(timeSinceTarget.TotalDays / 7);
        return weeksAgo;

    }

}
