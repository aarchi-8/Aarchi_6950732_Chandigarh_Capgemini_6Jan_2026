namespace Hospital_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient(1, "Rahul", 30);
            Doctor d1 = new Doctor(101, "Dr. Mehta", 45, "Cardiology");

            p1.GetRecord().AddHistory("Blood Pressure Issue");
            p1.GetRecord().AddHistory("Prescribed medicines");

            Appointment ap = new Appointment(p1, d1, DateTime.Now);

            Console.WriteLine("APPOINTMENT DETAILS");
            ap.DisplayAppointment();

            Console.WriteLine("\nMEDICAL HISTORY");
            p1.GetRecord().ShowHistory();
        }
    }
}
