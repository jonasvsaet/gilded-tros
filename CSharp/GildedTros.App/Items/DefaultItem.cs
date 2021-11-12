﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App
{
    public class DefaultItem : IInnItem
    {
        public int MaxQuality => 50;
        public int MinQuality => 0;

        public bool SellInDecreases => true;

        public Item Item { get; set; }

        public DefaultItem(Item item)
        {
            Item = item;
        }

        public void UpdateItem()
        {
            if (Item.SellIn <= 0)
            {
                Item.Quality -= 2;
            }
            else
            {
                Item.Quality--;
            }
        }
    }
}
