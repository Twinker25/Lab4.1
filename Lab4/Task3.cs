using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecrNum
{
    class cornum
    {
        public void game(int a, int b, int c)
        {
            Random r = new Random();
            Console.WriteLine("Genering number...");
            int cor;
            while (true)
            {
                cor = r.Next(a, b);
                Console.WriteLine(cor);
                if (cor == c)
                {
                    Console.WriteLine("The computer has guessed your number!!!");
                    break;
                }
            }
        }
    }
}
