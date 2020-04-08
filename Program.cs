using System;
using HomeWork8;
namespace HomeWork7._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5};
            System.Console.WriteLine("Before using methods: ");
            foreach(int ekz in arr)
            System.Console.WriteLine(ekz);
            System.Console.WriteLine($"The end was: {ArrayHelper.Pop(ref arr)}");
            System.Console.WriteLine("After using methods: ");
            foreach(int ekz in arr)
            System.Console.WriteLine(ekz);
            double[] arr2 = {23.55, 12.88, 3.4729, 2.0, 22345.9};
            System.Console.WriteLine("Before using methods: ");
            foreach(double ekz in arr2)
            System.Console.WriteLine(ekz);
            System.Console.WriteLine($"New length: {ArrayHelper.Push(ref arr2,1234.5678)}");
            System.Console.WriteLine("After using methods: ");
            foreach(double ekz in arr2)
            System.Console.WriteLine(ekz);
            decimal[] arr3 = {1222.89m, 849.373m, 228.0m, 73638.88m};
            System.Console.WriteLine("Before using methods: ");
            foreach(decimal ekz in arr3)
            System.Console.WriteLine(ekz);
            System.Console.WriteLine($"The begin was: {ArrayHelper.Shift(ref arr3)}");
            System.Console.WriteLine("After using methods: ");
            foreach(decimal ekz in arr3)
            System.Console.WriteLine(ekz);
            string[] arr4 = {"Sun", "Moon", "Sea", "Lake"};
            System.Console.WriteLine("Before using methods: ");
            foreach(string ekz in arr4)
            System.Console.WriteLine(ekz);
            System.Console.WriteLine($"New length: {ArrayHelper.UnShift(ref arr4, "Bank")}");
            System.Console.WriteLine("After using methods: ");
            foreach(string ekz in arr4)
            System.Console.WriteLine(ekz);
        }
    }
}
