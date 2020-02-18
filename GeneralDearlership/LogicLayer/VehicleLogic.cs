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

        static Vehicle vehicle;

         static VehicleLogic()
        {
            millageBrackets = new List<MillageBracket>() { 
            
            new MillageBracket(0,100000,30000,0.4),
            new MillageBracket(100000,150000,15,0.3),
            new MillageBracket(150000,160000,15,0.1),


            };
            YearBrackets = new List<MillageBracket>() {
             new MillageBracket(0,2011,5000,0.15),
             new MillageBracket(2011,2015,10000,.01),
             new MillageBracket(2015,2019,30000,0.15),


            };
            vehicle = new Vehicle(50000, Spects.High, Colours.Flat, ServiceType.Medium, 60000, 2019);
        }


        public void BuyCar()
        {
            Console.WriteLine("Enter book value");
            vehicle.BookValue = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Select Type of vehicle from the following");
            // enum check
            Console.WriteLine("Eneter Vehicle millage");
            vehicle.Millage = double.Parse(Console.ReadLine());

            vehicle = new Vehicle(50000, Spects.High, Colours.Flat, ServiceType.Medium, 60000, 2019);
        }


        public decimal CalcServiceFee(Vehicle vehicle)
        {
            if (vehicle.TypeOfVehicle == VehicleType.Bus || vehicle.TypeOfVehicle == VehicleType.Truck)
            {
                //foreach (var item in Enum.GetNames(ServiceAddition))
                //{

                //}
                //if(Enum.)

                return vehicle.BookValue * ((decimal)vehicle.ServiceHistory / 100) +(vehicle.BookValue * ((decimal)vehicle.ServiceHistory / 100));
                // still need to add truck and bus logic
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
                        //still need to implement Bus and truck logic
                        //fee = vehicle.BookValue + (decimal)item.Percentage + (vehicle.BookValue + (decimal)item.Percentage * (decimal)item.AdditionalPercent);
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
