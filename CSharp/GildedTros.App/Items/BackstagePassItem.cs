using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class BackstagePassItem : IInnItem
    {
        public int MaxQuality => 50;
        public int MinQuality => 0;

        public bool SellInDecreases => true;

        public Item Item { get; set; }

        public BackstagePassItem(Item item)
        {
            Item = item;
        }

        public void UpdateItem()
        {
            if (Item.SellIn <= 0)
            {
                Item.Quality = 0;
            }
            else if (Item.SellIn <= 5)
            {
                Item.Quality += 3;
            }
            else if (Item.SellIn <= 10)
            {
                Item.Quality += 2;
            }
            else
            {
                Item.Quality++;
            }
        }
    }
}
