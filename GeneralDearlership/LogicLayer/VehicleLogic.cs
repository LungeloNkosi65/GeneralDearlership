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
            
            new MillageBracket(0,100000,30),
            new MillageBracket(100000,150000,15),
            new MillageBracket(150000,160000,15),


            };
            YearBrackets = new List<MillageBracket>() {
             new MillageBracket(0,2011,5),
             new MillageBracket(2011,2015,10),
             new MillageBracket(2015,2019,10),


            };
            vehicle = new Vehicle();
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
            if (vehicle.TypeOfVehicle != VehicleType.Car)
            {
                return vehicle.BookValue * ((decimal)vehicle.ServiceHistory / 100);
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
                if (vehicle.TypeOfVehicle != VehicleType.Car)
                {
                    //still need to implement Bus and truck logic
                    fee=vehicle.BookValue;
                    break;
                }
                else
                {
                    fee=vehicle.BookValue;
                }
            }
            return fee;
          //
        }


        public decimal YearFee(Vehicle vehicle)
        {
            decimal fee = 0;
            foreach (var item in YearBrackets)
            {
                if (vehicle.TypeOfVehicle != VehicleType.Car)
                {
                    //still need to implement Bus and truck logic
                    fee = vehicle.BookValue;
                    break;
                }
                else
                {
                    fee = vehicle.BookValue;
                }
            }
            return fee;

        }

        public decimal CalcColurFee(Vehicle vehicle) {
            return vehicle.BookValue + (decimal)vehicle.Colour;
        }

    }
}
