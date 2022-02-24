using System;
using System.Linq;

namespace lab1
{
    public class HW1 
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] a = new int[n];
            int m;
            int minIndex;

            for (int i = 0; i < n; i++) {
                a[i] = 0; 
                a[i] += customers[i];
            }
            for (int i = n; i < customers.Length; i++) {
                m = a.Min();
                minIndex = Array.IndexOf(a, m);
                a[minIndex] += customers[i];
            }
            m = a.Max();
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
            HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
            HW1.QueueTime(new int[] { 2, 3, 10 }, 2);

        }
    }
}
