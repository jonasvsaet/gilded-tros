using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Items
{
    public class LegendaryItem : IInnItem
    {
        public Item item;

        public LegendaryItem(Item item)
        {
            this.item = item;
        }

        public void UpdateItem()
        {
            item.Quality = 80;
        }
    }
}
