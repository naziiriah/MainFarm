namespace PoultryCore.Model;

public class Farm : PoultryBase
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public ICollection<FarmSection>? Sections { get; set; }


}
