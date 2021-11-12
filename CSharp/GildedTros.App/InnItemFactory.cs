using GildedTros.App.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App
{
    public static class InnItemFactory
    {
        public static IInnItem GetInnItemForItem(Item item)
        {
            switch (item.Name)
            {
                case "Good Wine":
                    return new WineItem(item);
                case "B-DAWG Keychain":
                    return new LegendaryItem(item);
                case "Backstage passes for Re:factor":
                case "Backstage passes for HAXX":
                    return new BackstagePassItem(item);
                case "Duplicate Code":
                case "Long Methods":
                case "Ugly Variable Names":
                    return new SmellyItem(item);
                default:
                    return new DefaultItem(item);
            }
        }
    }
}
