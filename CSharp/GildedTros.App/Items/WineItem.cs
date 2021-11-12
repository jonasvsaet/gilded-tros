using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class WineItem : IInnItem
    {
        public Item item;

        public WineItem(Item item)
        {
            this.item = item;
        }

        public void UpdateItem()
        {
            if (item.SellIn <= 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }
        }
    }
}
