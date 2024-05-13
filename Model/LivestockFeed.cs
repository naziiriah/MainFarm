namespace MainFarm.Model;

public class LivestockFeed : MainFarmBase
{
    public ICollection<MixedFeed> MixedFeeds { get; set; }

    public ICollection<ManufacturedFeed> ManufacturedFeeds { get; set; }

}
