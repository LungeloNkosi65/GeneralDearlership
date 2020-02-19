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
        public DisplayLogic()
        {
            vehicles = new List<Vehicle>() {
            new Vehicle("MERCEDES","Ut 80",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Truck,ServiceAddition.Full,290000),
            new Vehicle("BMW","M4",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,250000),
            new Vehicle("BMW","M2",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,240000),
            new Vehicle("AUDI","S3",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Car,ServiceAddition.Full,210000),
            new Vehicle("FORD","Ut60",10000,Spects.High,Colours.Flat,ServiceType.Full,150000,2019,VehicleType.Bus,ServiceAddition.Full,350000)
            };
            AvailableMakes = new List<string>();
        }
        public void StartApp()
        {
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
            int option = 0;
            Console.WriteLine("Available Makes");
            foreach (var item in AvailableMakes.Distinct())
            {
                option = AvailableMakes.IndexOf(item);
                Console.WriteLine($"\n({option}){item}");
            }
        }
        public static void GetModel(int vehicleMake)
        {
            foreach (var item in vehicles)
            {
                if (item.VehicleMake == AvailableMakes[vehicleMake])
                {
                    Console.WriteLine("\n Model :" + item.VehicleModel
                        +"\n Make :"+item.VehicleMake +"\n Millage :"+item.Millage +"\n Year :"+item.Year
                        +"\n Spects :"+item.Spect +"\n Service History :"+item.ServiceHistory+
                        "\n Book Value :"+item.BookValue.ToString("c")
                        +"\n Selling Price :"+item.SellingPrice.ToString("c")+"\n Profit :"+(item.SellingPrice-item.BookValue).ToString("c"));
                }
            }
        }
        public static void ValidOptionMessage()
        {
            Console.WriteLine("Please select a valid option");
        }
        public static void ViewAllVehicles()
        {
            Console.WriteLine();
            Console.WriteLine($"*********************** {vehicles.Count()} Available Vehicles ****************************");
            foreach (var item in vehicles)
            {
                Console.WriteLine($"\n Vehicle Type : {item.TypeOfVehicle} \n Vehicle Model : {item.VehicleModel}" +
                    $"\n Vehicle Make : {item.VehicleMake} \n Millage : {item.Millage} \n Year : {item.Year} " +
                    $"\n Spects : {item.Spect} \n Service History : {item.ServiceHistory} \n Colour : {item.Colour} \n Book Value : {item.BookValue.ToString("c")}" +
                    $"\n Selling Price : {item.SellingPrice.ToString("c")}");
            }
        }

        public static void InvalidInput()
        {
            Console.WriteLine($"\n Inavalid input please enter valid value");
        }
    }
}
