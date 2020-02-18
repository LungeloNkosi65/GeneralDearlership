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
        Car=1,
        Truck=2,
        Bus=3
    }
   public class Vehicle
    {
        public VehicleType TypeOfVehicle { get; set; }
        public double Millage { get; set; }
        public Spects Spect { get; set; }
        public Colours Colour { get; set; }
        public ServiceType ServiceHistory { get; set; }
        public ServiceAddition ExtraCharges { get; set; }
        public string VehicleMake { get; set; }
        public decimal BookValue { get; set; }
        public string VehicleModel { get; set; }
        public double Year { get; set; }
        public decimal SellingPrice { get; set; }

        public Vehicle() { }
        public Vehicle(string make, string vehicleModel, double millage, Spects spects,Colours colours,ServiceType serviceType,decimal bookValue,double year,VehicleType vehicleType,ServiceAddition serviceAddition) 
        {
            VehicleMake = make;
            VehicleModel = vehicleModel;
            Millage = millage;
            Spect = spects;
            Colour = colours;
            ServiceHistory = serviceType;
            BookValue = bookValue;
            Year = year;
            TypeOfVehicle = vehicleType;
            ExtraCharges = serviceAddition;
        }
        public Vehicle(string make, string vehicleModel, double millage, Spects spects, Colours colours, ServiceType serviceType, decimal bookValue, double year, VehicleType vehicleType, ServiceAddition serviceAddition, decimal sellingPrice)
        {
       
            VehicleMake = make;
            VehicleModel = vehicleModel;
            Millage = millage;
            Spect = spects;
            Colour = colours;
            ServiceHistory = serviceType;
            BookValue = bookValue;
            Year = year;
            TypeOfVehicle = vehicleType;
            ExtraCharges = serviceAddition;
            SellingPrice = sellingPrice;

        }

    }
}
