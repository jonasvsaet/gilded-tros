using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class LegendaryItem : IInnItem
    {
        public int MaxQuality => 80;
        public int MinQuality => 0;

        public bool SellInDecreases => false;

        public Item Item { get; set; }

        public LegendaryItem(Item item)
        {
            Item = item;
        }

        public void UpdateItem()
        {
            Item.Quality = 80;
        }
    }
}
