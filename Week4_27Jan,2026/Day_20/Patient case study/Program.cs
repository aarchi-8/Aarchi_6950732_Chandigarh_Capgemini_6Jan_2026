namespace Patient_case_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patientList = new List<Patient>();
            int NoOfPatients, i;
            string name, illness, city;
            int age;

            Console.WriteLine("Enter the Number of Patients-:");
            NoOfPatients = int.Parse(Console.ReadLine());   
            Patient p = new Patient();

            for(i = 0; i < NoOfPatients; i++)
            {
                Console.WriteLine("Enter Patient" + i + 1 + " details-:");
                Console.WriteLine("Enter Patient Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Patient's Age: ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Patient's Illness: ");
                illness = Console.ReadLine();
                Console.WriteLine("Enter Patient's City: ");
                city = Console.ReadLine();
                p = new Patient(name , age, illness, city);
                patientList.Add(p);
            }

            int choice;
            PatientBO p1 = new PatientBO();
            string opt;

            do
            {
                Console.WriteLine("Enter your choice: \n1) Display Patient Details \n2) Display Youngest Patient Details \n3) Display Patients from City");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Patient Name: ");
                        name = Console.ReadLine();
                        p1.DisplayPatientDetails(patientList, name);
                        break;
                    case 2:
                        p1.DisplayYoungestPatientDetails(patientList);
                        break;
                    case 3:
                        Console.WriteLine("Enter City Name: ");
                        city = Console.ReadLine();
                        p1.displayPatientsFromCity(patientList, city);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to continue(Yes/No)?");
                opt = Console.ReadLine();
            } while (opt.Equals("Yes"));
        }
    }
}
