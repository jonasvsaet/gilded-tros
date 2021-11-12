using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class SmellyItem : IInnItem
    {
        public Item item;
        
        public SmellyItem(Item item)
        {
            this.item = item;
        }

        public void UpdateItem()
        {
            if (item.SellIn <= 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }
        }
    }
}
