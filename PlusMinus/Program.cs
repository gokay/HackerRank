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

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal plus = 0, minus = 0, zero = 0;
        int length = arr.Count;
        decimal result;

        foreach(var num in arr)
        {
            switch (num)
            {
                case 0: zero++;break;
                case > 0: plus++; break;
                case < 0: minus++; break;

            }
        }

        
        result = Math.Round((plus / length), 6);
        Console.WriteLine(result);

        result = Math.Round((minus / length), 6);
        Console.WriteLine(result);

        result = Math.Round((zero / length), 6);
        Console.WriteLine(result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        if (n > 0 && n<= 100)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }


    }
}
