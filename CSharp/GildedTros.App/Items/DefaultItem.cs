using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App
{
    public class DefaultItem : IInnItem
    {
        public Item item;

        public DefaultItem(Item item)
        {
            this.item = item;
        }

        public void UpdateItem()
        {
            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality--;
            }
        }
    }
}
