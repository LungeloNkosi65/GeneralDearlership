using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralDearlership.Models;

namespace GeneralDearlership.LogicLayer
{
    public class VehicleBuyingLogic
    {
        public static List<Vehicle> AvailableVehicles;
        static Vehicle vehicle;
        static VehicleLogic vehicleLogic;
         static VehicleBuyingLogic()
        {
            AvailableVehicles = new List<Vehicle>();
            vehicle = new Vehicle();
            vehicleLogic = new VehicleLogic();
        }

        public void Start()
        {
            Array listOptions;
            string input = "";
            double input2 = 0;

            Console.WriteLine("Enter Vehicle Make");
            vehicle.VehicleMake = Console.ReadLine();
            Console.WriteLine("Enter vehicle model");
            vehicle.VehicleModel = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter book value");
                input2 = double.Parse(Console.ReadLine());
                if (input2 > 0)
                {
                    vehicle.BookValue =(decimal) input2;
                }
            } while (false);
         
            Console.WriteLine("Select vehicle type from the following");
            listOptions = Enum.GetNames(typeof(VehicleType));
            for (int i = 0; i < listOptions.Length; i++)
            {
                Console.WriteLine($"({i}) :{listOptions.GetValue(i)}\n");
            }
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) >= 0 && int.Parse(input) < listOptions.Length)
                {
                    vehicle.TypeOfVehicle = (VehicleType)Enum.Parse(typeof(VehicleType), (listOptions.GetValue(int.Parse(input))).ToString());
                    break;
                }
                Console.WriteLine("Invalid option please select valid option");
            } while (true);
            //millage
            do
            {
                Console.WriteLine("Eneter Vehicle millage");
                input2 = double.Parse(Console.ReadLine());
                if (input2 >= 0)
                {
                    vehicle.Millage = input2;
                }
                else
                {
                    Console.WriteLine("Please enter vali millage");
                }
            } while (false);
            //spects
            do
            {
                Console.WriteLine("Select vehicle spects from the following");
                foreach (var name in Enum.GetNames(typeof(Spects)))
                {
                    Console.WriteLine("\n" + name);
                }
                // enum check

                input = Console.ReadLine();

                if (Enum.IsDefined(typeof(Spects), input))
                {
                    vehicle.Spect = (Spects)Enum.Parse(typeof(Spects), input);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid spects inputed, please try again.");
                }
            } while (true);
            //Colour
            do
            {
                Console.WriteLine("Select vehicle colour from the following");
                foreach (var name in Enum.GetNames(typeof(Colours)))
                {
                    Console.WriteLine("\n" + name);
                }
                // enum check
                input = Console.ReadLine();

                if (Enum.IsDefined(typeof(Colours), input))
                {
                        vehicle.Colour = (Colours)Enum.Parse(typeof(Colours), input);
                        break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid colour  inputed, please try again.");
                }

            } while (true);
            //servicehistory
            do
            {

                Console.WriteLine("Select vehicle service history from the following");
                foreach (var name in Enum.GetNames(typeof(ServiceType)))
                {
                    Console.WriteLine("\n" + name);
                }
                // enum check
                input = Console.ReadLine();

                if (Enum.IsDefined(typeof(ServiceType), input))
                {
                    vehicle.ServiceHistory = (ServiceType)Enum.Parse(typeof(ServiceType), input);
                    break;
                }
                else
                {
                    Console.WriteLine("\n\nInvalid service history type inputed, please try again.");
                }
            } while (true);

           
            Console.WriteLine("Selling Price "+ vehicleLogic.CalcSellingPrice(vehicle));
            vehicle.SellingPrice = vehicleLogic.CalcSellingPrice(vehicle);
            AvailableVehicles.Add(vehicle);
            Display();
        }


        public void Display()
        {
            string input = " ";
            Console.WriteLine( AvailableVehicles.Count() +"vehicle bought would you like to purchase another vehicle  Yes(Y) or No(N)?" );
            input = Console.ReadLine();
            if (input =="Y")
            {
                Start();
            }
            
        }
    }
}
