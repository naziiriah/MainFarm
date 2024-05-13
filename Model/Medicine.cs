using MainFarm.Enums;

namespace MainFarm.Model;

public class Medicine : MainFarmBase
{
    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public eMedicineType TypeOfMedicine { get; set; }

    public int Duration { get; set; }

    public DateTime Start { get; set; }

    public DateTime End { get; set; }

    public string Clinic { get; set; } = "";

    public bool RequiresVet {  get; set; }


}
