using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Task2.Var2
{
    public class Student : Man
    {
        public int YearOfStart { get; set; }
        public int Course { get; set; }
        public int GroupNum { get; set; }
        public Student(string name, int age, double weight, int length, int year, int course, int group) : base(name, age, weight, length)
        {
            this.YearOfStart = year;
            this.Course = course;
            this.GroupNum = group;
        }

    }
}
