using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Salary_Management
{
    public class Salary
    {
        public int salary;
        public string designation;
        public Dictionary<string, int> empList = new Dictionary<string, int>
        {
            {"Manager", 40000 },
            {"HR", 45000 },
            {"Consultant", 30000 },
            {"Software Engineer", 38000 }
        };

        public int totalSalary()
        {
            //int sum = 0;
            //foreach(var m in empList)
            //{
            //    sum += m.Value; 
            //}
            //return sum; 
            return empList.Sum(x => x.Value);
            //return empList.Value.Sum(); // linq
        }
        public string getSalary(string designation)
        {

            //var result = empList.Where(x=>x.Key == designation)
            //    .Select(x => x.Value).FirstOrDefault();
            //return salary == 0 ? "Designation not found" : result.ToString();
            if (empList.ContainsKey(designation))
            {
                return empList[designation].ToString();
            }
            else
            {
                return "Designation not found";
            }
        }
        public void updateSalary(string designation, int newSalary)
        {

            var key = empList.Keys.FirstOrDefault(x => x.Equals(designation, StringComparison.OrdinalIgnoreCase));

            if(key != null)
            {
                empList[key]= newSalary;
                Console.WriteLine("Salary Updated");
            }
            else
            {
                Console.WriteLine("Designation not found");
            }
            //if (empList.ContainsKey(designation))
            //{
            //    empList[designation] = newSalary;
            //    Console.WriteLine("Salary updated");
            //}
            //else
            //{
            //    Console.WriteLine("Designation not found");
            //}
        }
    }
}
