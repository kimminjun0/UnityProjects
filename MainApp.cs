using System.Diagnostics;

namespace _0507_CSharp
{
    internal class MainApp
    {
       
            public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }

        public static void Main(string[] args)
        {
            int total1 = Sum(1, 2);
            Debug.WriteLine($"Sum(1, 2) = {total1}"); // 출력: Sum(1, 2) = 3

            int total2 = Sum(1, 2, 3, 4, 5, 6);
            Debug.WriteLine($"Sum(1, 2, 3, 4, 5, 6) = {total2}"); // 출력: Sum(1, 2, 3, 4, 5, 6) = 21
        }


    }
    
}
