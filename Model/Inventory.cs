using System.ComponentModel.DataAnnotations;
using MainFarm.Enums;

namespace MainFarm.Model;

public class Inventory : MainFarmBase
{

    public string Name { get; set; } = "Inventory";

    public string Location {  get; set; }

    public string Description { get; set; }

    public string Type { get; set; } = "Poultry Inventory";


    public ICollection<ItemFormat> Invents { get; set; }
}
