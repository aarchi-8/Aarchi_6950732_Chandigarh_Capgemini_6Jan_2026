using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    internal class Vehicle
    {
        protected string vehicleNo;
        protected double rentPerDay;
        protected bool isRented;

        public void AddVehicle()
        {
            Console.Write("Enter Vehicle Number: ");
            vehicleNo = Console.ReadLine();

            Console.Write("Enter Rent Per Day: ");
            rentPerDay = double.Parse(Console.ReadLine());

            isRented = false;
        }

        public double CalculateRent(int days)
        {
            return rentPerDay * days;
        }

        public void RentVehicle()
        {
            isRented = true;
        }

        public void ReturnVehicle()
        {
            isRented = false;
        }
    }
    class Car : Vehicle
    {
        public void DisplayCar()
        {
            Console.WriteLine("Car Number: " + vehicleNo);
        }
    }
    class Bike : Vehicle
    {
        public void DisplayBike()
        {
            Console.WriteLine("Bike Number: " + vehicleNo);
        }
    }
    class Truck : Vehicle
    {
        public void DisplayTruck()
        {
            Console.WriteLine("Truck Number: " + vehicleNo);
        }
    }
    class Customer
    {
        private string name;

        public void AddCustomer()
        {
            Console.Write("Enter Customer Name: ");
            name = Console.ReadLine();
        }

        public string GetName()
        {
            return name;
        }
    }
    class RentalTransaction
    {
        public void Rent(Vehicle v, int days)
        {
            v.RentVehicle();
            Console.WriteLine("Total Rent: " + v.CalculateRent(days));
        }

        public void Return(Vehicle v)
        {
            v.ReturnVehicle();
            Console.WriteLine("Vehicle Returned Successfully");
        }
    }
                                                

}
