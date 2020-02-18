using GeneralDearlership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.LogicLayer
{
   public  class DisplayLogic
    {
        public static List<Vehicle> vehicles;
        public static List<string> AvailableMakes;


        //public void StartApp()
        //{
        //    string input = " ";
           
        //    do
        //    {
        //        Console.WriteLine("Hellow what would you like to do today (0)Buy car or (1)Sell car");
        //        input = Console.ReadLine();
        //        if (input.All(Char.IsDigit))
        //        {
        //            if (input == 0)
        //            {
        //                -
        //            }
        //        }
        //    } while (true);
        //}
        public DisplayLogic()
        {
            vehicles = new List<Vehicle>() {
            new Vehicle("MERCEDES","Ut-80",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Truck,ServiceAddition.Full,2500),
            new Vehicle("BMW","M4",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,35000),
            new Vehicle("BMW","M2",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,35000),
            new Vehicle("AUDI","S3",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,35000),
            new Vehicle("FORD","Ut60",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Bus,ServiceAddition.Full,200000)
            };
            AvailableMakes = new List<string>();
        }
        static DisplayLogic()
        {
            vehicles = new List<Vehicle>();
        }
        public static void GetMake(VehicleType vehicleType)
        {
            foreach (var item in vehicles)
            {
                if (item.TypeOfVehicle == vehicleType)
                {
                    AvailableMakes.Add(item.VehicleMake);
                  
                }
            }
            DisticntMakes();
        }

        public static void DisticntMakes()
        {
            foreach (var item in AvailableMakes.Distinct())
            {
                Console.WriteLine("\n Make " +item);
            }
        }
        public static void GetModel(string vehicleMake)
        {
            foreach (var item in vehicles)
            {
                if (item.VehicleMake == vehicleMake)
                {
                    Console.WriteLine("\n Model :" + item.VehicleModel
                        +"\n Make :"+item.VehicleMake +"\n Millage :"+item.Millage
                        +"\n Spects :"+item.Spect +"\n Service History :"+item.ServiceHistory+
                        "\n Selling Price :"+item.SellingPrice);
                }
            }
        }

        public static void DispVehicles() { }
    }
}
