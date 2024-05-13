using PoultryCore.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoultryCore.Model;

public class MixedFeed : PoultryBase
{
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
