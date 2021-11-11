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
                if (item.Name == "B-DAWG Keychain")
                    continue;

                //Decreasers
                if (item.Name != "Good Wine" 
                    && item.Name != "Backstage passes for Re:factor"
                    && item.Name != "Backstage passes for HAXX")
                {
                    if(item.SellIn <= 0)
                    {
                        item.Quality -= 2;
                    }
                    else
                    {
                        item.Quality--;
                    }

                }
                //Increasers
                else
                {
                    if (item.Name == "Backstage passes for Re:factor"
                    || item.Name == "Backstage passes for HAXX")
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
                    else
                    {
                        if(item.SellIn <= 0)
                        {
                            item.Quality += 2;
                        }
                        else
                        {
                            item.Quality++;
                        }
                    }
                }

                item.SellIn--;
                ClampQuality(item);
            }
        }

        private void ClampQuality(Item item)
        {
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
            else if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }

    }
}
