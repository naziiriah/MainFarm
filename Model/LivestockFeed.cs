namespace PoultryCore.Model;

public class LivestockFeed : PoultryBase
{
    public ICollection<MixedFeed> MixedFeeds { get; set; }

    public ICollection<ManufacturedFeed> ManufacturedFeeds { get; set; }

}
