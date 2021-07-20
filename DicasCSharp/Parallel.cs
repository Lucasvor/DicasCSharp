using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicasCSharp
{
    class Parallel
    {
        static void Main(string[] args)
        {
            NormalForEach();
            ParallelForEach();


            System.Threading.Tasks.Parallel.For(0, 10000, i =>
              {
                  Console.WriteLine(i);
              });

            //Informando a quantidade de Threads a utilizar.
            System.Threading.Tasks.Parallel.For(0, 10000, new System.Threading.Tasks.ParallelOptions{
                MaxDegreeOfParallelism = 16
            },i =>
            {
                Console.WriteLine(i);
            });

            Console.Read();
        }
        public static int[] NormalForEach()
        {
            var array = new int[1_000_000];
            for(var i = 0; i < 1_000_000; i++)
            {
                array[i] = i;
            }
            return array;
        }
        public static int[] ParallelForEach()
        {
            var array = new int[1_000_000];
            
            System.Threading.Tasks.Parallel.For(0, 1_000_000, i =>{
                array[i] = i;
            });
            return array;
        }
    }

}
