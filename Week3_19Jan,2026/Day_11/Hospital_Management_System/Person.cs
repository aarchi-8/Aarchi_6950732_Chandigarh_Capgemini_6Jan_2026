using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management_System
{
    class Person
    {
        protected int id;
        protected string name;
        protected int age;

        public Person(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine("ID: " + id + " Name: " + name + " Age: " + age);
        }
    }
    class Patient : Person
    {
        private MedicalRecord record;

        public Patient(int id, string name, int age)
            : base(id, name, age)
        {
            record = new MedicalRecord();
        }

        public MedicalRecord GetRecord()
        {
            return record;
        }
    }
    class Doctor : Person
    {
        private string specialization;

        public Doctor(int id, string name, int age, string specialization)
            : base(id, name, age)
        {
            this.specialization = specialization;
        }

        public void DisplayDoctor()
        {
            DisplayPerson();
            Console.WriteLine("Specialization: " + specialization);
        }
    }
    class Nurse : Person
    {
        private string shift;

        public Nurse(int id, string name, int age, string shift)
            : base(id, name, age)
        {
            this.shift = shift;
        }
    }
    class MedicalRecord
    {
        private List<string> history = new List<string>();

        public void AddHistory(string details)
        {
            history.Add(details);
        }

        public void ShowHistory()
        {
            foreach (string h in history)
                Console.WriteLine(h);
        }
    }
    class Appointment
    {
        private Patient patient;
        private Doctor doctor;
        private DateTime date;

        public Appointment(Patient p, Doctor d, DateTime date)
        {
            patient = p;
            doctor = d;
            this.date = date;
        }

        public void DisplayAppointment()
        {
            Console.WriteLine("Appointment on " + date);
            patient.DisplayPerson();
            doctor.DisplayDoctor();
        }
    }

}
