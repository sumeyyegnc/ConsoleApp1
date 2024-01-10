namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to sort?");
            byte count = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number");
            byte end = byte.Parse(Console.ReadLine());


            if (count > (end - start))
            {
                Console.WriteLine("Cannot generate unique numbers with this range and count.");
                return;
            }

            int[] numbers = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int newNumber;
                do
                {
                    newNumber = rnd.Next(start, end);
                } while (Array.IndexOf(numbers, newNumber) != -1);

                numbers[i] = newNumber;
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}