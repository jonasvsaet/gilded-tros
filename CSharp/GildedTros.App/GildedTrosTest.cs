using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        [Fact]
        //Good wine increases quality
        public void WineIncreaseQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Good Wine", SellIn = 1, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        //Quality is never more than 50
        public void WineClampQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Good Wine", SellIn = 1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        //Quality changes double the amount after sell in
        public void WineIncreaseQualityAfterSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Good Wine", SellIn = 0, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(2, Items[0].Quality);
        }

        [Fact]
        //Quality changes double the amount after sell in
        public void WineIncreaseQualitySellInNegativeTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Good Wine", SellIn = -1, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(2, Items[0].Quality);
        }

        [Fact]
        //Qaulity decreases by 1
        public void ItemDecreaseQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Item", SellIn = 1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(49, Items[0].Quality);
        }

        [Fact]
        //Qaulity never less than 0
        public void ItemClampQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Item", SellIn = 1, Quality = 0 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        //Qaulity decreases double after sell in
        public void ItemDecreaseQualityAfterSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Item", SellIn = 0, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(48, Items[0].Quality);
        }

        [Fact]
        //Qaulity decreases double after sell in
        public void ItemDecreaseQualitySellInNegativeTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Item", SellIn = -1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(48, Items[0].Quality);
        }

        [Fact]
        //Legendary items don't change in quality
        public void LegendaryQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "B-DAWG Keychain", SellIn = 1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        //Legendary items don't change in quality
        public void LegendaryQualityNegativeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "B-DAWG Keychain", SellIn = -1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }

        [Fact]
        //Legendary items don't change in quality
        public void LegendaryQualityZeroSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "B-DAWG Keychain", SellIn = -1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(50, Items[0].Quality);
        }


        [Fact]
        //Legendary items don't have to be sold
        public void LegendarySellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "B-DAWG Keychain", SellIn = 1, Quality = 50 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(1, Items[0].SellIn);
        }

        [Fact]
        //Backstage pass quality increases by 1 when sellin above 10
        public void BackstageQualitySellinAbove10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 15, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(21, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality increases by 2 when sellin 10
        public void BackstageQualitySellin10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 10, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality increases by 2 when sellin below 10
        public void BackstageQualitySellinBelow10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 6, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(22, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality increases by 3 when sellin below 10
        public void BackstageQualitySellin5()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 5, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality increases by 3 when sellin below 10
        public void BackstageQualitySellinBelow5()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 1, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(23, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality drops to 0 when sellin 0 or less
        public void BackstageQualitySellin0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = 0, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        //Backstage pass quality drops to 0 when sellin negative
        public void BackstageQualitySellinMegative()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes for Re:factor", SellIn = -1, Quality = 20 } };
            GildedTros app = new GildedTros(Items);
            app.UpdateQuality();
            Assert.Equal(0, Items[0].Quality);
        }

    }
}