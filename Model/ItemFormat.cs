using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoultryCore.Model;

public class ItemFormat : PoultryBase
{
    [DisplayName("Name of Inventory")]
    [Required]
    public string Name { get; set; } = "";

    [DisplayName("How much is removed for mixing feed")]
    public int UsedForFeeding { get; set; }

    [DisplayName("Date Of Purchase")]
    public DateOnly DateOfPurchase { get; set; }

    [DisplayName("Weight of One Item")]
    public int WeightOfOne { get; set; }
    
    [DisplayName("How many Bags Bought")]
    public int TotalBags { get; set; }

    [DisplayName("Or What is the total weight")]
    public int TotalWeight { get; set; }

    [ForeignKey("InventoryGuid")]
    public Guid InventoryGuid { get; set; }

    public Inventory Inventory { get; set; }

    [ForeignKey("OtherInventoryStuffsGuid")]
    public Guid? OtherInventoryStuffs { get; set; }
}
