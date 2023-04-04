using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoText
{
    class pseudotext
    {
        public void text(int a, int b, int c)
        {
            char[] gol_arr = { 'a', 'e', 'i', 'o', 'u' };
            char[] pr_arr = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            Random random = new Random();
            int k = 0;
            while (k < c)
            {
                int gol_k = 0;
                int pr_k = 0;
                string word = "";

                while (gol_k < a || pr_k < b)
                {
                    if ((gol_k < a && random.Next(2) == 0) || pr_k >= b)
                    {
                        int index = random.Next(gol_arr.Length);
                        word += gol_arr[index];
                        gol_k++;
                    }
                    else
                    {
                        int index = random.Next(pr_arr.Length);
                        word += pr_arr[index];
                        pr_k++;
                    }
                }
                Console.Write(word + " ");
                k += word.Length + 1;
            }
            Console.WriteLine("\nGeneration finished");
        }
    }
}