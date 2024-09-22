using System;

namespace GildedRoseKata;

public class Item
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
}

public partial class AgingItem
{
    private Item item;
    private string agingType;
    
    public AgingItem(Item item, string agingType)
    {
        this.item = item;
        this.agingType = agingType;
    }

    public void UpdateQuality()
    {
        Type thisType = this.GetType();
        thisType.GetMethod(this.agingType + "_UpdateQuality").Invoke(this, null);
    }

}
