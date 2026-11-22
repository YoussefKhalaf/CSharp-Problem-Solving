namespace Reverse_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();                   
            for(int i = 0; i<size/2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[size-1-i];
                numbers[size-1-i] = temp;
            }
            foreach(int i in numbers)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
