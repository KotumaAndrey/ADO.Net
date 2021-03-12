using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Task1.Var2
{
    public class Triangle
    {
        Dot[] dot;
        public Triangle(Dot dot1, Dot dot2, Dot dot3)
        {
            dot = new Dot[3];
            dot[0] = dot1;
            dot[1] = dot2;
            dot[2] = dot3;
        }
      
        public double Perimeter()
        {
            double res = 0;
            int n = 3;
            for (int i = 0; i <n; i++)
            {
                if (i != n  -1)
                {
                    res += Math.Sqrt(Math.Abs((dot[i].X - dot[i + 1].X) * (dot[i].X - dot[i + 1].X) +
                (dot[i].Y - dot[i + 1].Y) * (dot[i].Y - dot[i + 1].Y)));
                }
                else
                {
                    res += Math.Sqrt(Math.Abs((dot[n-1].X - dot[0].X) * (dot[n - 1].X - dot[0].X) +
                (dot[n - 1].Y - dot[0].Y) * (dot[n - 1].Y - dot[0].Y)));
                }
            }
            return res;
        }
        public double Area()
        {
            return 0.5 * Math.Abs((dot[1].X - dot[0].X) * (dot[2].Y - dot[0].Y) - 
                (dot[2].X - dot[0].X) * (dot[1].Y - dot[0].Y));
        }
        public bool IsValid()
        {
            return Area() > 0;
        }
    }
}
