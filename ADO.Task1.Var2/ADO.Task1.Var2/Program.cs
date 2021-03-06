using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Периметр: " + triangle.Perimeter());
            Console.WriteLine("Площадь: " + triangle.Area());
            Console.Read();
        }
    }
}
