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
            var logic = new VehicleLogic();
           var vehicle = new Vehicle(50000, Spects.High, Colours.Flat, ServiceType.Medium, 60000, 2019);
            Console.WriteLine(logic.CalcSellingPrice(vehicle));
            Console.ReadLine();
        }
        
       
    }
}
