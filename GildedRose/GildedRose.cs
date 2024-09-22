using System;
using System.Collections.Generic;

namespace GildedRoseKata;
using System.Reflection;

public class GildedRose
{

    private ReadAgingType readAgindDataTable;
    IList<Item> Items;


    // Constructor
    public GildedRose()
    {
        ReadAgingType readAgindDataTable = new ReadAgingType();
        readAgindDataTable.ReadItems();
        this.readAgindDataTable = readAgindDataTable;
    }

    public void addItems(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        foreach (var item in Items)
        {
            string agingType = readAgindDataTable.GetItemAgingType(item.Name);
            AgingItem agingItem = new AgingItem(item, agingType); // Cast the item to an aging item
            agingItem.UpdateQuality();
        }
    }
}