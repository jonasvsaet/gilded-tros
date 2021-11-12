using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class BackstagePassItem : IInnItem
    {
        public Item item;

        public BackstagePassItem(Item item)
        {
            this.item = item;
        }

        public void UpdateItem()
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn <= 10)
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
