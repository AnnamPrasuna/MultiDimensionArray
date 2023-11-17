using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 5];
            
            Console.WriteLine("a array has {0} dimensions ", a.Rank);
            //Console.WriteLine("b array has {0} dimensions ", b.Rank);
            Console.WriteLine("size of a array is" + a.Length);
           // Console.WriteLine("size of a array is" + b.Length);
            Console.WriteLine("size of rows in a "+a.GetLength(0));
            Console.WriteLine("size of a column in a " + a.GetLength(1));
            Console.WriteLine( "default values of a");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine( );
            }
            int[,] b = new int[3, 5]
            {
                { 12,45,67,90,78},
                { 23,89,90,56,34},
                { 23,90,67,45,89}
            };
            Console.WriteLine("size of an array b "+b.Length);
            Console.WriteLine("number of rows in b "+b.GetLength(0));
            Console.WriteLine("number of columns in b " + b.GetLength(1));
            Console.WriteLine( "after initialization");
            for  (int i = 0;i < b.GetLength(0); i++)
            {
                for(int j = 0;j < b.GetLength(1); j++)
                {
                    Console.Write(" "+b[i,j]);
                }
                Console.WriteLine( );
            }
            Object[,] obj = new object[2,5]
            {
                {"prasuna",23,78,90,56},
                {"pravallika",67,90,78,56}
            };
            for (int i = 0; i < obj.GetLength(0); i++)
            {
                for (int j = 0; j < obj.GetLength(1); j++)
                {
                    Console.Write(" "+obj[i,j]);
                }
                Console.WriteLine( );
            }

            Console.ReadKey();
        }
    }
}
