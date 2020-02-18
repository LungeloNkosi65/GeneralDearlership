using GeneralDearlership.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.LogicLayer
{
    struct SellingInput
    {
        public VehicleType vehicleType { get; set; }
    }

    public class SellingVehicleLogic
    {
        public List<Vehicle> AvailabelVehicles { get; set; }
        SellingInput sellingInput;
        DisplayLogic displayLogic;
        public SellingVehicleLogic()
        {
            displayLogic = new DisplayLogic();
            sellingInput = new SellingInput();
        }

        public void SellVehicle()
        {
            Array listOptions;
            VehicleType vehicle;
            string input = "";


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
                        vehicle = (VehicleType)Enum.Parse(typeof(VehicleType), (listOptions.GetValue(int.Parse(input))).ToString());
                        break;
                    }
                    Console.WriteLine("Invalid option please select valid option");
                } while (true);

            DisplayLogic.GetMake(vehicle);
            input = Console.ReadLine().ToUpper();
            DisplayLogic.GetModel(input);

        }


    }
}
