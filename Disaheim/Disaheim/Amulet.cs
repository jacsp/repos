using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double 
            LowQualityValue = 12.5, 
            MediumQualityValue = 20.0, 
            HighQualityValue = 27.5;
        
        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;
                    break;
                case Level.medium:
                    return MediumQualityValue;
                    break;
                case Level.high:
                    return HighQualityValue;
                    break;
                default:
                    return HighQualityValue;
                    break;
            }
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }

        public Amulet(string itemId, Level quality): 
            this(itemId, quality, "") 
        {
        }

        public Amulet(string itemId): 
            this(itemId, Level.medium, "") 
        {
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
