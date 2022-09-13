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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int a1 = 0, b1 = 0;

        for (int i = 0; i < 3; i++)
        {
            if (a[i] == b[i]) continue;
            if (a[i] > b[i]) a1++;
            if (a[i] < b[i]) b1++;
        }
        result.Add(a1);
        result.Add(b1);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        Console.WriteLine(result[0] + " " + result[1]);

    }
}
