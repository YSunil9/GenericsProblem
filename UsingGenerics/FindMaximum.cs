using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenerics
{
    internal class FindMaximum<T> where T : IComparable
    {
        public void MaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is Maximum of all", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is Maximum of all", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("{0} is Maximum of all", third);
            }
            else
                Console.WriteLine("All The Numbers Are Equal");
        }

    }
}
