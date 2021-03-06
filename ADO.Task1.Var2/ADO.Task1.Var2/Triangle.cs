using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    public class Triangle
    {
        private Dot dot1;
        private Dot dot2;
        private Dot dot3;
        public Triangle(double dot1_X, double dot1_Y, double dot2_X,
            double dot2_Y, double dot3_X, double dot3_Y)
        {
            try
            {
                if (dot1_X == dot2_X || dot2_X == dot3_X || dot3_X == dot1_X)
                    throw new FormatException();
                if (dot1_Y == dot2_Y || dot2_Y == dot3_Y || dot3_Y == dot1_Y)
                    throw new FormatException();
            }
            catch(FormatException)
            {
                Console.WriteLine("Вы пытаетесь создать вырожденный треугольник. Пожалуйста, введите корректные координаты.");
                return;
            }
            this.dot1 = new Dot(dot1_X, dot1_Y);
            this.dot1 = new Dot(dot2_X, dot2_Y);
            this.dot1 = new Dot(dot3_X, dot3_Y);
        }
        public Triangle()
        {
            double dot1_X = 0;
            double dot1_Y = 0;
            double dot2_X = 0;
            double dot2_Y = 0;
            double dot3_X = 0;
            double dot3_Y = 0;
        Start:
            Console.WriteLine("Введите координаты вершин треугольника в 1 строчке, разделяя их пробелом" +
                "в формате x1 y1 x2 y2 x3 y3");
            string[] dots = Console.ReadLine().Split(' ');
        
            try
            {
                if (!double.TryParse(dots[0], out dot1_X))
                    throw new FormatException();
               
                if (!double.TryParse(dots[1], out dot1_Y))
                    throw new FormatException();
                
                if (!double.TryParse(dots[2], out dot2_X))
                    throw new FormatException();
                
                if (!double.TryParse(dots[3], out dot2_Y))
                    throw new FormatException();
                
                if (!double.TryParse(dots[4], out dot3_X))
                    throw new FormatException();
                
                if (!double.TryParse(dots[5], out dot3_Y))
                    throw new FormatException();
                

                if (dot1_X == dot2_X || dot2_X == dot3_X || dot3_X == dot1_X)
                    throw new ArgumentException();
                if (dot1_Y == dot2_Y || dot2_Y == dot3_Y || dot3_Y == dot1_Y)
                    throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Вы пытаетесь создать вырожденный треугольник. Пожалуйста, введите корректные координаты.");
                goto Start;
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод данных, введите еще раз.");
                goto Start;
            }
            dot1_X = double.Parse(dots[0]);
            dot1_Y = double.Parse(dots[1]);
            dot2_X = double.Parse(dots[2]);
            dot2_Y = double.Parse(dots[3]);
            dot3_X = double.Parse(dots[4]);
            dot3_Y = double.Parse(dots[5]);
            this.dot1 = new Dot(dot1_X, dot1_Y);
            this.dot2 = new Dot(dot2_X, dot2_Y);
            this.dot3 = new Dot(dot3_X, dot3_Y);

        }
        public double Perimeter()
        {
            double res = 0;
            res += Math.Sqrt(Math.Abs((dot1.x - dot2.x) * (dot1.x - dot2.x) + 
                (dot1.y - dot2.y) * (dot1.y - dot2.y)));
            res += Math.Sqrt(Math.Abs((dot2.x - dot3.x) * (dot2.x - dot3.x) +
                (dot2.y - dot3.y) * (dot2.y - dot3.y)));
            res += Math.Sqrt(Math.Abs((dot3.x - dot1.x) * (dot3.x - dot1.x) +
                (dot3.y - dot1.y) * (dot3.y - dot1.y)));
            return res;
        }
        public double Area()
        {
            return 0.5 * Math.Abs((dot2.x - dot1.x) * (dot3.y - dot1.y) - 
                (dot3.x - dot1.x) * (dot2.y - dot1.y));
        }
    }
}
