namespace primenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check :");
            int input = Convert.ToInt32(Console.ReadLine());
            bool ifEnteredCheck = false;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    Console.WriteLine("The number  is not a prime number");
                    ifEnteredCheck = true;
                    break;

                }
            }
        }
    }
}


