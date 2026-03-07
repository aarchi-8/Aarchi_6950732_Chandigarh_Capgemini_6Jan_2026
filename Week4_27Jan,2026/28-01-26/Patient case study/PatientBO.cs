using Patient_case_study;
using System;
using System.Collections.Generic;
using System.Text;
internal class PatientBO
{
    public void DisplayPatientDetails(List<Patient> patientList, string name)
    {
        List<Patient> l1 = (from p in patientList
                            where p.name == name
                            select p).ToList();
        int li = l1.Count;
        if(li < 0)
        {
            Console.Write("Patient name "+ name +" not found");
        }
        else
        {
            Console.WriteLine("Name   Age   Illness   City");
            foreach(Patient p in l1)
            {
                Console.Write(p.ToString());
            }
        }
    }
    public void DisplayYoungestPatientDetails(List<Patient> patientList)
    {
        int age = (from p in patientList
                   select p.age).Min();
        var x = (from p in patientList
                 where p.age == age
                 select p);
        Console.WriteLine("Name   Age   Illness   City");
        foreach(var p in x)
        {
            Console.Write(p.ToString());
        }
    }
    public void displayPatientsFromCity(List<Patient> patientList, string cname)
    {
        List<Patient> l = (from p in patientList
                           where p.name == cname
                           select p ).ToList();
        int li = l.Count;
        if(li < 0)
        {
            Console.WriteLine("City named {0} not found" + cname);
        }
        else
        {
            Console.WriteLine("Name   Age   Illness   City");
            foreach(var p in l)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}