namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int column = 8;
            int bit = 0;
            while (column >= 1)
            {
                Console.WriteLine("Enter a bit: ");
                bit = Convert.ToInt32(Console.ReadLine());
                answer = answer + (column * bit);
                column = column / 2;
            }
            Console.WriteLine($"\n Decimal value is: {answer}");
        }
    }
}