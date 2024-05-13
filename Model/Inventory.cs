using Poultry.Enums;
using System.ComponentModel.DataAnnotations;

namespace PoultryCore.Model;

public class Inventory : PoultryBase
{

    public string Name { get; set; } = "Inventory";

    public string Location {  get; set; }

    public string Description { get; set; }

    public string Type { get; set; } = "Poultry Inventory";


    public ICollection<ItemFormat> Invents { get; set; }
}
