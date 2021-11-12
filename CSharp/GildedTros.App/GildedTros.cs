using GildedTros.App.Items;
using System.Collections.Generic;

namespace GildedTros.App
{
    public class GildedTros
    {
        IList<Item> Items;
        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var innItem = InnItemFactory.GetInnItemForItem(item);
                innItem.UpdateItem();

                ClampQuality(innItem);

                if (innItem.SellInDecreases)
                {
                    innItem.Item.SellIn--;
                }

            }
        }

        private void ClampQuality(IInnItem innItem)
        {
            if (innItem.Item.Quality > innItem.MaxQuality)
            {
                innItem.Item.Quality = innItem.MaxQuality;
            }
            else if (innItem.Item.Quality < innItem.MinQuality)
            {
                innItem.Item.Quality = innItem.MinQuality;
            }
        }

    }
}
