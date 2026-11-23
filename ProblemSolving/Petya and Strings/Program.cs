#region Solution_1
//namespace Petya_and_Strings
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            String s1 = Console.ReadLine();
//            String s2 =Console.ReadLine();
//            s1 = s1.ToLower();
//            s2 = s2.ToLower();
//            char[] chars1 = s1.ToCharArray();
//            char[] chars2 = s2.ToCharArray();
//            int flag = 0;
//            for (int i = 0; i < chars1.Length; i++)
//            {
//                if (chars1[i] > chars2[i])
//                {
//                    Console.Write(1);
//                    flag = 1;
//                    break;
//                }
//                else if (chars1[i] < chars2[i])
//                {
//                    Console.Write(-1);
//                    flag = 1;
//                    break;
//                }
//            }
//            if(flag == 0)
//            {
//                Console.Write(0);
//            }
//        }
//    }
//}
#endregion
#region Solution_2
namespace Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            int result=String.Compare(s1, s2,StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(Math.Sign(result));
        }
    }
}
#endregion