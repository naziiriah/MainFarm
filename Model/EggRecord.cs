using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainFarm.Model;

public class EggRecord : MainFarmBase
{

    [Required]
    public DateTime TodaysDate { get; set; }

    [Required]
    public required ICollection<EggsPicked> PickedEggs { get; set; }

    [ForeignKey("FarmSectionGuid")]
    public Guid FarmSectionGuid { get; set; }

    public FarmSection? FarmSection { get; set; }
}
