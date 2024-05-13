using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MainFarm.Model;

public class OtherInventoryStuffs : MainFarmBase
{
    public string Name { get; set; } = "";

    [DisplayName("How much is removed for mixing feed")]
    public int UsedForFeeding { get; set; }

    [DisplayName("Date Of Purchase")]
    public DateOnly DateOfPurchase { get; set; }

    [DisplayName("Weight of One Item")]
    public int WeightOfOne { get; set; }

    [DisplayName("How many Bags Bought")]
    public int TotalBags { get; set; }

    [DisplayName("Total Weight")]
    public int TotalWeight { get; set; }

    [ForeignKey("InventoryGuid")]
    public Guid InventoryGuid { get; set; }

}