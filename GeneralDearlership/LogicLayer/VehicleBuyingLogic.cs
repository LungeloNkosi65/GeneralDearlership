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
         public VehicleBuyingLogic()
        {
            AvailableVehicles = new List<Vehicle>();
            vehicle = new Vehicle();
            vehicleLogic = new VehicleLogic();
        }

        public void BuyVehicle()
        {
            Array listOptions;
            string input = "";
            double input2 = 0;

            Console.WriteLine("Enter Vehicle Make");
            input= Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input) || !(String.IsNullOrWhiteSpace(input)))
            {
                vehicle.VehicleMake = input;
            }
            Console.WriteLine("Enter vehicle model");
            vehicle.VehicleModel = Console.ReadLine();
            Console.WriteLine("Eneter book value");
            do
            {
                input =Console.ReadLine();
                if(input.All(Char.IsDigit))
                {
                    if (!(String.IsNullOrWhiteSpace(input)))
                    {
                        vehicle.BookValue = decimal.Parse(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("...Please enter valid book value");
                    }
                  
                }
                else
                {
                    DisplayLogic.InvalidInput();
                }
            } while (true);
            Console.WriteLine("Eneter vehicle year");
            do
            {
                input = Console.ReadLine();
                if (input.All(Char.IsDigit) )
                {
                    if (!(String.IsNullOrWhiteSpace(input)))
                    {
                        vehicle.Year = double.Parse(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("...Please enter valid year value");
                    }
                }
                else
                {
                    DisplayLogic.InvalidInput();
                }
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
                    DisplayLogic.InvalidInput();
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
           
            //spects
            Console.WriteLine("Select vehicle spects from the following");
            listOptions = Enum.GetNames(typeof(Spects));
            for (int i = 0; i < listOptions.Length; i++)
            {
                Console.WriteLine($"({i}) :{listOptions.GetValue(i)}\n");
            }
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) >= 0 && int.Parse(input) < listOptions.Length)
                {
                    vehicle.Spect = (Spects)Enum.Parse(typeof(Spects), (listOptions.GetValue(int.Parse(input))).ToString());
                    break;
                }
                DisplayLogic.ValidOptionMessage();
            } while (true);
            //Colour
            Console.WriteLine("Select vehicle colour from the following");
            listOptions = Enum.GetNames(typeof(Colours));
            for (int i = 0; i < listOptions.Length; i++)
            {
                Console.WriteLine($"({i}) :{listOptions.GetValue(i)}\n");
            }
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) >= 0 && int.Parse(input) < listOptions.Length)
                {
                    vehicle.Colour = (Colours)Enum.Parse(typeof(Colours), (listOptions.GetValue(int.Parse(input))).ToString());
                    break;
                }
                DisplayLogic.ValidOptionMessage();
            } while (true);
            //servicehistory
            Console.WriteLine("Select vehicle service history from the following");
            listOptions = Enum.GetNames(typeof(ServiceType));
            for (int i = 0; i < listOptions.Length; i++)
            {
                Console.WriteLine($"({i}) :{listOptions.GetValue(i)}\n");
            }
            do
            {
                input = Console.ReadLine();
                if (int.Parse(input) >= 0 && int.Parse(input) < listOptions.Length)
                {
                    if (vehicle.TypeOfVehicle == VehicleType.Bus || vehicle.TypeOfVehicle == VehicleType.Truck)
                    {
                        vehicle.ServiceHistory = (ServiceType)Enum.Parse(typeof(ServiceType), (listOptions.GetValue(int.Parse(input))).ToString()); 
                        vehicle.ExtraCharges = (ServiceAddition)Enum.Parse(typeof(ServiceAddition), (listOptions.GetValue(int.Parse(input))).ToString());
                        break;
                    }
                    else
                    {
                        vehicle.ServiceHistory = (ServiceType)Enum.Parse(typeof(ServiceType), input);
                        break;
                    }
                }
                DisplayLogic.ValidOptionMessage();

            } while (true);
            Console.WriteLine("Selling Price "+ vehicleLogic.CalcSellingPrice(vehicle).ToString("c"));
            AvailableVehicles.Add(vehicle);
            Display();
        }


        public void Display()
        {
            string input = " ";
            Console.WriteLine( AvailableVehicles.Count() +"vehicle bought would you like to purchase another vehicle  Yes(Y) or No(N)?" );
            do
            {
                input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    BuyVehicle();
                    break;
                }
                else if (input == "N")
                {
                    Console.WriteLine("Good Bye");
                    break;
                }
                else
                {
                    DisplayLogic.ValidOptionMessage();
                }
            } while (true);
           
            
        }
    }
}
