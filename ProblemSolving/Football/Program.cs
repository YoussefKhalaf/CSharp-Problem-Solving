namespace Football
{
    internal class Program
    {
        static void Main(string[] args)   
        {
            int count = 1;
            String players = Console.ReadLine();
            for (int i = 0; i < players.Length-1; i++)   
            {
                
                if (players[i] == players[i + 1])
                {
                   count++;
                }
                else
                {
                    count = 1;
                }
                if (count == 7)
                {
                    Console.Write("YES");
                    return;
                }
            }
            Console.Write("NO");
        }
    }
}
