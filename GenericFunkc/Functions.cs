using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunkc
{
    public static class Functions
    {
        public static T FindLargest<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("List must not be null or empty.");
            }

            T largest = list[0];
            foreach (T item in list)
            {
                if (item.CompareTo(largest) > 0)
                {
                    largest = item;
                }
            }

            return largest;
        }

        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }


        
    }
}
