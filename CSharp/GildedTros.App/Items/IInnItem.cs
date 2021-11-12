using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App
{
    public interface IInnItem 
    {
        public int MaxQuality { get; }
        public int MinQuality { get; }
        
        public bool SellInDecreases { get; }

        Item Item { get; set; }

        void UpdateItem();

    }
}
