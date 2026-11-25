using System.Text;

namespace Helpful_Maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            String s = Console.ReadLine();
            int[] numbers = new int[3];
            if (!s.Contains('+'))
            {
                Console.Write(s);
                return;
            }
            for(int i=0; i<s.Length; i+=2)
            {
                if (s[i] == '1') count1++;
                if (s[i] == '2') count2++;
                if (s[i] == '3') count3++;
            }
            StringBuilder result=new StringBuilder();
            while (count1 != 0)
            {
                if (result.Length > 0)
                {
                    result.Append('+');
                }
                result.Append('1');
                count1--;
            }
            while (count2 != 0)
            {
                if (result.Length > 0)
                {
                    result.Append('+');
                }
                result.Append('2');
                count2--;
            }
            while (count3 != 0)
            {
                if (result.Length > 0)
                {
                    result.Append('+');
                }
                result.Append('3');
                count3--;
            }
            Console.Write(result);
        }
    }
}
