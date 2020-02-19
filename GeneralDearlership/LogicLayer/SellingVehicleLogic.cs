using GeneralDearlership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.LogicLayer
{
    

    public class SellingVehicleLogic
    {
        public List<Vehicle> AvailabelVehicles { get; set; }
        DisplayLogic displayLogic;
        public SellingVehicleLogic()
        {
            displayLogic = new DisplayLogic();
        }
        public void SellVehicle()
        {
            Array listOptions;
            VehicleType vehicle;
            string input = "";

                Console.WriteLine("Select vehicle type from the following that you want to sell");
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
                        vehicle = (VehicleType)Enum.Parse(typeof(VehicleType), (listOptions.GetValue(int.Parse(input))).ToString());
                        break;
                    }
                DisplayLogic.ValidOptionMessage();
                } while (true);

            do
            {
                try
                {
                    DisplayLogic.GetMake(vehicle);
                    input = Console.ReadLine();
                    if (input.All(Char.IsDigit) && int.Parse(input) >= 0)
                    {
                        DisplayLogic.GetModel(int.Parse(input));
                        break;
                    }
                }
                catch (Exception ex)
                {
                    DisplayLogic.ValidOptionMessage();
                }

            } while (true);

        }

    }
}
