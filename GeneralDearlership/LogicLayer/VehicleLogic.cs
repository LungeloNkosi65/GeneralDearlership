using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralDearlership.Models;

namespace GeneralDearlership.LogicLayer
{
   public class VehicleLogic
    {
        public static List<MillageBracket> millageBrackets;
        public static List<MillageBracket> YearBrackets;
         static VehicleLogic()
        {
            millageBrackets = new List<MillageBracket>() { 
            
            new MillageBracket(0,100000,30000,0.4),
            new MillageBracket(100000,150000,15,0.3),
            new MillageBracket(150000,double.MaxValue,15,0.1),


            };
            YearBrackets = new List<MillageBracket>() {
             new MillageBracket(0,2011,5000,0.15),
             new MillageBracket(2011,2015,10000,.01),
             new MillageBracket(2015,2019,30000,0.15),
             new MillageBracket(2019,double.MaxValue,30000,0.15),
            };
        }

        public decimal CalcServiceFee(Vehicle vehicle)
        {
            if (vehicle.TypeOfVehicle == VehicleType.Bus || vehicle.TypeOfVehicle == VehicleType.Truck)
            {


                return vehicle.BookValue * ((decimal)vehicle.ServiceHistory / 100) +(vehicle.BookValue * ((decimal)vehicle.ExtraCharges / 100));
            }
            else
            {
                return vehicle.BookValue * ((decimal)vehicle.ServiceHistory / 100);
            }
        }

        public decimal CalcMillageFee(Vehicle vehicle)
        {
            decimal fee = 0;
            foreach (var item in millageBrackets)
            {
                if (vehicle.Year >= item.LowerValue && vehicle.Year < item.UperValue)
                {
                    if (vehicle.TypeOfVehicle == VehicleType.Bus || vehicle.TypeOfVehicle == VehicleType.Truck)
                    {
                        return (decimal)((item.Percentage)+ (item.Percentage*item.AdditionalPercent));
                    }
                    else
                    {
                        return (decimal)item.Percentage;
                    }
                }
            }
            return fee;
        }

        public decimal YearFee(Vehicle vehicle)
        {
            decimal fee = 0;
            foreach (var item in YearBrackets)
            {
                if(vehicle.Year>=item.LowerValue && vehicle.Year < item.UperValue)
                {
                    if (vehicle.TypeOfVehicle == VehicleType.Bus || vehicle.TypeOfVehicle == VehicleType.Truck)
                    {
                        //still need to implement Bus and truck logic
                        return (decimal)((item.Percentage) + (item.Percentage * item.AdditionalPercent));
                    }
                    else
                    {
                        return (decimal)item.Percentage;
                    }
                }
              
            }
            return fee;

        }

        public decimal CalcColurFee(Vehicle vehicle) {
            return  (decimal)vehicle.Colour;
        }

        public decimal CalcSellingPrice(Vehicle vehicle)
        {
            return vehicle.BookValue+ CalcColurFee(vehicle) + CalcMillageFee(vehicle) + CalcServiceFee(vehicle) + YearFee(vehicle);
        }

    }
}
