namespace Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            String[] words = new String[numberOfWords];
            for (int i = 0; i < numberOfWords; i++)
            {
                words[i] = Console.ReadLine();
            }
            for (int i = 0; i < numberOfWords; i++)
            {
                if (words[i].Length > 10)
                {
                    Console.WriteLine(
                        $"{words[i][0]}{(words[i].Length)-2}{words[i][words[i].Length - 1]}");
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
