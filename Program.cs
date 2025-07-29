namespace Challenge_Lab_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                int[] numbers = [1, 2, 3, 4, 5, 13, 33, 731, 888];
                foreach(int num in numbers)
                    Console.WriteLine($"{num} : {NumberContains3(num)}");
            }
            else
            {
                foreach (var arg in args)
                {
                    Console.WriteLine($"{arg} : {NumberContains3(Convert.ToInt32(arg))}");
                }
            }
        }

        static bool NumberContains3(int num)
        {
            while(num > 0)
            {
                if (num % 10 == 3)
                    return true;
                num /= 10;
            }
            return false;
        }
    }
}
