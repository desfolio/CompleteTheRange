using System;
using System.Linq;

namespace CompleteTheRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var thisArray = new int[] { 1, 3, 4, 7, 9 };
            var min = 0;
            var max = 0;
            var missCount = 0;

            foreach (var num in thisArray)
            {
                min = Math.Min(thisArray[0], num);
                max = Math.Max(thisArray[0], num);
            }

            for (int i = min; i < max; i++)
            {
                if (!thisArray.Contains(i))
                {
                    missCount++;
                }
            }

            Console.WriteLine(missCount);
        }
    }
}
