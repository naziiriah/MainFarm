using System.ComponentModel.DataAnnotations.Schema;

namespace PoultryCore.Model;

public class EggsPicked : PoultryBase
{

    public int NumberOfCrates { get; set; }

    public int PiecesLeft { get; set; }

    [ForeignKey("EggRecordGuid")]
    public Guid? EggRecordGuid { get; set; }

    public EggRecord? EggRecord { get; set; }
}
