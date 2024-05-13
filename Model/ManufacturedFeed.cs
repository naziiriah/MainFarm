using PoultryCore.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace PoultryCore.Model;

public class ManufacturedFeed :  PoultryBase
{
    public string FeedBrand { get; set; } = "";
    
    public eFeedType FeedType { get; set; }

    [DisplayName("Weight Per Bag")]
    public eAmount FeedWeightPerBag { get; set; }

    [DisplayName("Total number of Bags")]
    public int FeedCount { get; set; }

    public bool IsFeedFinished { get; set; }

    public DateOnly DateOfProcurement { get; set; }

    [ForeignKey(nameof(LiveStockFeedGuid))]
    public Guid LiveStockFeedGuid { get; set; }

}
