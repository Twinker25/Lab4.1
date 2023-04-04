namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.WriteLine("Task 1");
            int end;
            Console.WriteLine("Enter and of range: ");
            end = int.Parse(Console.ReadLine());
            Pair.number a = new Pair.number();
            a.pair(end);
            NotPair.number b = new NotPair.number();
            b.notpair(end);
            Prime.number c = new Prime.number();
            c.prime(end);
            Fibon.number d = new Fibon.number();
            d.fib(end);*/

            //2
            /*Console.WriteLine("Task 2");
            string sym;
            Console.Write("Enter symbol to paint figure: ");
            sym = Console.ReadLine();
            Console.Write("\nEnter size of square: ");
            int size1 = int.Parse(Console.ReadLine());
            Square.figure e = new Square.figure();
            e.square(sym, size1);

            Console.Write("\nEnter size of rectangle: ");
            int size2 = int.Parse(Console.ReadLine());
            int size3 = int.Parse(Console.ReadLine());
            Rectangle.figure f = new Rectangle.figure();
            f.rectangle(sym, size2, size3);

            Console.Write("\nEnter size of triangle: ");
            int size4 = int.Parse(Console.ReadLine());
            Triangle.figure g = new Triangle.figure();
            g.triangle(sym, size4);*/

            //3
            /*Console.WriteLine("Task 3");
            int ran1, ran2, n;
            Console.WriteLine("Enter range: ");
            ran1 = int.Parse(Console.ReadLine());
            ran2 = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Enter your number: ");
                n = int.Parse(Console.ReadLine());
                if (n < ran1 || n > ran2)
                {
                    Console.WriteLine("This number is outside the range!!!");
                }
            } while (n < ran1 || n > ran2);
            CorrecrNum.cornum g = new CorrecrNum.cornum();
            g.game(ran1, ran2, n);*/

            //4
            Console.WriteLine("Task 4");
            Console.Write("Number of vowels: ");
            int gol = int.Parse(Console.ReadLine());
            Console.Write("Number of consonants: ");
            int pr = int.Parse(Console.ReadLine());
            Console.Write("Length of words: ");
            int len = int.Parse(Console.ReadLine());
            PseudoText.pseudotext h = new PseudoText.pseudotext();
            h.text(gol, pr, len);
        }
    }
}