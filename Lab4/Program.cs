namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Task 1");
            string input;
            int num;
            try
            {
                Console.Write("Enter number: ");
                input = Console.ReadLine();
                num = int.Parse(input);
                Console.WriteLine($"Your number: {num}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("This number is maximize than type int");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format of number");
            }
        }
    }
}