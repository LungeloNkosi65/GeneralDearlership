using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.Models
{
   public class MillageBracket
    {
        public decimal LowerValue { get; set; }
        public decimal UperValue { get; set; }
        public decimal Percentage { get; set; }

        public MillageBracket(decimal lowerValue,decimal uperValue,decimal percentage)
        {
            LowerValue = lowerValue;
            UperValue = uperValue;
            Percentage = percentage;
        }
    }
}
