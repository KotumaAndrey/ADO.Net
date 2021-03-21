using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Task2.Var2
{
    public class Man
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }
        protected int Length { get; set; }

        public Man(string name, int age, double weight, int length)
        {
            this.Age = age;
            this.Name = name;
            this.Weight = weight;
            this.Length = length;
        }
    }
}
