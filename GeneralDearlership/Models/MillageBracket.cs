using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.Models
{
   public class MillageBracket
    {
        public double LowerValue { get; set; }
        public double UperValue { get; set; }
        public double Percentage { get; set; }
        public double AdditionalPercent { get; set; }

        public MillageBracket(double lowerValue, double uperValue, double percentage,double additionalPercent)
        {
            LowerValue = lowerValue;
            UperValue = uperValue;
            Percentage = percentage;
            AdditionalPercent = additionalPercent;
        }
    }
}
