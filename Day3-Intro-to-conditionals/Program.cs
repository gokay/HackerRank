using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static bool isOdd(int a)
    {
        return a % 2 == 0 ? false : true; 
    }

    public static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());

        if (N >= 1 && N <= 100)
        {
            if (isOdd(N))
            {
                Console.WriteLine("Weird");
            }

            if (!isOdd(N) && (N >= 2 && N <= 5))
            {
                Console.WriteLine("Not Weird");
            }

            if (!isOdd(N) && (N >= 6 && N <= 20))
            {
                Console.WriteLine("Weird");
            }

            if (!isOdd(N) && (N > 20))
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
