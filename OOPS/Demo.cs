using System;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int[] arr = {
            24,
            10,
            56,
            32,
            10,
            43,
            88,
            32
         };
            var d = new Dictionary<int, int>();

            foreach (var res in arr)
            {
                if (d.ContainsKey(res))
                    d[res]++;
                else
                    d[res] = 1;
            }

            foreach (var val in d)
                Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);

        }

    }
}
using System;
using System.Collections.Generic;

namespace Demo
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int[] arr = {
            24,
            10,
            56,
            32,
            10,
            43,
            88,
            32
         };
            var d = new Dictionary<int, int>();

            foreach (var res in arr)
            {
                if (d.ContainsKey(res))
                    d[res]++;
                else
                    d[res] = 1;
            }

            foreach (var val in d)
                Console.WriteLine("{0} occurred {1} times", val.Key, val.Value);

        }

    }
}