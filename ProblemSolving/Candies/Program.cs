namespace Candies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKids = int.Parse(Console.ReadLine());
            int[] numberOfCandies = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] positions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int position1 = positions[0];
            int position2 = positions[1];
            int sum = 0;
            while (position1 <= position2)
            {
                sum += numberOfCandies[position1++];
            }
            Console.Write(sum);
        }
    }
}
