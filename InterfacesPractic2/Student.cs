using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractic2
{
    public class Student : IStudent
    {
        public string FullName { get; set; }

        public int[] Grades{ get; set; }

        public string Name { get; set; }

        public double GetAvgGrade()
        {
            int sum = 0;
            foreach(var grade in Grades)
            {
                sum += grade;
            }

            return sum / Grades.Count();
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
