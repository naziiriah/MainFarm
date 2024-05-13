using System.ComponentModel.DataAnnotations.Schema;

namespace MainFarm.Model;

public class EggsPicked : MainFarmBase
{

    public int NumberOfCrates { get; set; }

    public int PiecesLeft { get; set; }

    [ForeignKey("EggRecordGuid")]
    public Guid? EggRecordGuid { get; set; }

    public EggRecord? EggRecord { get; set; }
}
