using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Task2.Var2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man man = GetMan();
            Student student = GetStudent();
            Man man2 = student;
            Man man3 = GetStudent();
        }


        private static double GetDouble()
        {
            FormatterResult<double> res = null;
            StringFormatter stringFormatter = new StringFormatter();
            do
            {
                string input = Console.ReadLine();
                res = stringFormatter.GetDouble(input);

                if (res.IsValid)
                {
                    Console.WriteLine("All right");
                }
                else
                {
                    Console.WriteLine("Errors:");
                    string s = string.Join("\n", res.Errors.Select(str => str.ErrorMessage));
                    Console.WriteLine(s);
                }
            }
            while (!res.IsValid);

            return res.Value;
        }

        private static int GetInt()
        {
            FormatterResult<int> res = null;
            StringFormatter stringFormatter = new StringFormatter();
            do
            {
                string input = Console.ReadLine();
                res = stringFormatter.GetInt(input);

                if (res.IsValid)
                {
                    Console.WriteLine("All right");
                }
                else
                {
                    Console.WriteLine("Errors:");
                    string s = string.Join("\n", res.Errors.Select(str => str.ErrorMessage));
                    Console.WriteLine(s);
                }
            }
            while (!res.IsValid);

            return res.Value;
        }

        private static string GetString()
        {
            FormatterResult<string> res = null;
            StringFormatter stringFormatter = new StringFormatter();
            do
            {
                string input = Console.ReadLine();
                res = stringFormatter.GetString(input);

                if (res.IsValid)
                {
                    Console.WriteLine("All right");
                }
                else
                {
                    Console.WriteLine("Errors:");
                    string s = string.Join("\n", res.Errors.Select(str => str.ErrorMessage));
                    Console.WriteLine(s);
                }
            }
            while (!res.IsValid);

            return res.Value;
        }

        private static Man GetMan()
        {
            Man man;
            Console.WriteLine("Введите имя человека");
            string name = GetString();
            Console.WriteLine("Введите возраст");
            int age = GetInt();
            Console.WriteLine("Введите вес");
            double weight = GetDouble();
            Console.WriteLine("Введите рост");
            int length = GetInt();
            man = new Man(name, age, weight, length);
            return man;
        }

        private static Student GetStudent()
        {
            Student student;
            Console.WriteLine("Введите имя человека");
            string name = GetString();
            Console.WriteLine("Введите возраст");
            int age = GetInt();
            Console.WriteLine("Введите вес");
            double weight = GetDouble();
            Console.WriteLine("Введите рост");
            int length = GetInt();
            Console.WriteLine("Введите год начала учебы");
            int year = GetInt();
            Console.WriteLine("Введите номер курса");
            int course = GetInt();
            Console.WriteLine("Введите номер группы");
            int group = GetInt();
            student = new Student(name, age, weight, length, year, course, group);
            return student;
        }
    }
}
