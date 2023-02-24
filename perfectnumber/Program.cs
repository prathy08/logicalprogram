namespace perfectnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check");
            int input = Convert.ToInt32(Console.ReadLine());
            int accumulator = 0;
            for (int i= 1;i < input; i++)
            {
                if(input % i == 0)
                {
                    accumulator++;  
                }
            }
            if (accumulator == input)
            {
                Console.WriteLine("The number "+input+"  is perfect");
            }
            else { Console.WriteLine("The number " + input + " is not perfect"); }


        }
    }
}