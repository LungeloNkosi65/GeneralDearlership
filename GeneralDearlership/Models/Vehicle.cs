using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.Models
{
    public enum ServiceType
    {
        Full=40,
        Medium=30,
        None = 0
    }

    public enum ServiceAddition
    {
        Full=15,
        Medium=10,
        None=0
    }
    public enum Spects
    {
        High=30,
        Low=15
    }
    public enum Colours
    {
        Flat=0,
        Metal=15000,
    }
    public enum VehicleType
    {
        Car,Truck,Bus
    }
   public class Vehicle
    {
        public VehicleType TypeOfVehicle { get; set; }
        public double Millage { get; set; }
        public Spects Spect { get; set; }
        public Colours Colour { get; set; }
        public ServiceType ServiceHistory { get; set; }
        public List<Make> Makes { get; set; }
        public decimal BookValue { get; set; }
        public double Year { get; set; }

        public Vehicle() { }
        public Vehicle(double millage, Spects spects,Colours colours,ServiceType serviceType,decimal bookValue,double year) 
        {
            Millage = millage;
            Spect = spects;
            Colour = colours;
            ServiceHistory = serviceType;
            BookValue = bookValue;
            Year = year;
        }

    }
}
