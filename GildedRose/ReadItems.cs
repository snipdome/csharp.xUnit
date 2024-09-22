
using System.Collections.Generic;
using System;
using System.IO;

namespace GildedRoseKata
{

    class ReadAgingType
    {
        private string path = "../../../../resources/ItemTypes.csv";

        // Read the datatable from a csv file
        public void ReadItems()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), this.path);

            // Read the file
            string[] lines = System.IO.File.ReadAllLines(path);

            itemTypes = new Dictionary<string, string>();

            // Skip the first line
            lines = lines[1..];
            foreach (string line in lines)
            {
                int index = line.LastIndexOf(',');
                string firstPart = line.Substring(0, index);
                string lastPart = line.Substring(index + 1);
                firstPart = firstPart.Trim('"');
                itemTypes.Add(firstPart, lastPart);
            }
        }


        // In this variable, keep the mapping between the item name and the aging item class
        private Dictionary<string, string> itemTypes;

        public string GetItemAgingType(string itemName)
        {
            if (itemTypes.ContainsKey(itemName))
            {
                return itemTypes[itemName];
            }
            else
            {   
                return "Default";
            }
        }
    }

}