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

            //sellVehicle.SellVehicle();
            buyVehicle.Start();
            //MakeLogic.ListMakes();

            Console.ReadKey();
            Console.ReadLine();
        }
        
       
    }
}
