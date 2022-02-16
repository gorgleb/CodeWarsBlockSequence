using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            long n = 55;
            Console.WriteLine(BlockSeq.solve(n));


        }


    }





    public class BlockSeq
    {

        public static int solve(long n)
        {

            string[] array = new string[] { };
            string temp = "1";
            char[] chararray = new char[] { };
        
            Array.Resize(ref array, Convert.ToInt32(n + 10));
            array[1] = "1";

            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + i.ToString();
                temp = String.Concat(temp, array[i]);

            }
            //Console.WriteLine(temp);
            chararray = temp.ToCharArray();
            return Convert.ToInt32((Char.GetNumericValue(chararray[n-1])));
        }


    }
}




