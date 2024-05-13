namespace MainFarm.Model;

public class Farm : MainFarmBase
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<FarmSection>? Sections { get; set; }


}
