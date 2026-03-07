using System;
using System.Collections.Generic;
using System.Text;
internal class PatientBO
{
    void DisplayPatientDetails(List<Patient> patientList, string name)
    {
        List<Patient> l1 = (from p in patientList
                            where p.name == name
                            select p).ToList();

    }
}
