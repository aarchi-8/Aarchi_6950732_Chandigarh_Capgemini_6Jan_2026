namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.AddVehicle();

            Customer c = new Customer();
            c.AddCustomer();

            RentalTransaction rt = new RentalTransaction();
            rt.Rent(car, 3);
            rt.Return(car);

            Console.ReadLine();

        }
    }
}
