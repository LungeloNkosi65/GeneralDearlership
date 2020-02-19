using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralDearlership.LogicLayer;
using GeneralDearlership.Models;

namespace GeneralDearlership
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var sellVehicle = new SellingVehicleLogic();
            var buyVehicle = new VehicleBuyingLogic();
            string input = " ";
            Console.WriteLine($"Hellow what would you like to do ? \n(0) Buy vehicle  \n(1) Sell vehicle \n(3) View all vehicles");

            do
            {
                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    DisplayLogic.ValidOptionMessage();

                }
                else
                {
                    if (input.All(Char.IsDigit))
                    {
                        if (int.Parse(input) == 0)
                        {
                            buyVehicle.BuyVehicle();
                            break;
                        }
                        else if (int.Parse(input) == 1)
                        {
                            sellVehicle.SellVehicle();
                            break;
                        }
                        else if (int.Parse(input) == 3)
                        {
                            DisplayLogic.ViewAllVehicles();
                        }
                        else
                        {
                            DisplayLogic.ValidOptionMessage();

                        }

                    }
                    else
                    {
                        DisplayLogic.ValidOptionMessage();

                    }
                }
                
               
            } while (true);

            Console.ReadLine();
        }
        
       
    }
}
