using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4{
    class Class0
    {
       public int a;
       public static Class0 c;

    }
    class Class1:Class0
    {
        public static void Main(string[] args) {
            Class0 c = new Class0(); 
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

        }
    }
}