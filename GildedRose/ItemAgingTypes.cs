using System;
using System.Collections.Generic;
using System.IO;

namespace GildedRoseKata
{
    public partial class AgingItem
    {

        // The following methods are the aging types
        
        public void Default_UpdateQuality()
        {
            int qualityDecay = (item.SellIn>0) ? 1 : 2;
            item.SellIn -= 1;
            item.Quality -= qualityDecay;
            item.Quality = (item.Quality>0) ? item.Quality : 0;
        }

        public void Cheese_UpdateQuality()
        {
            int qualityDecay = (item.SellIn>0) ? 1 : 2;
            item.SellIn -= 1;
            item.Quality = item.Quality + qualityDecay;
            item.Quality = (item.Quality<50) ? item.Quality : 50;
        }

        public void BackstagePass_UpdateQuality()
        {
            item.SellIn -= 1;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }
            item.Quality = (item.Quality<50) ? item.Quality : 50;
        }

        public void LegendaryItem_UpdateQuality()
        {
        }

        public void ConjuredItem_UpdateQuality()
        {
            int qualityDecay = (item.SellIn>0) ? 2 : 4;
            item.SellIn -= 1;
            item.Quality -= qualityDecay;
            item.Quality = (item.Quality>0) ? item.Quality : 0;
        }

    }
}