using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class figure
    {
        public void square(string a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Rectangle
{
    class figure
    {
        public void rectangle(string a, int b, int c)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Triangle
{
    class figure
    {
        public void triangle(string a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}