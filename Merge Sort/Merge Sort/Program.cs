using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {
        public static int[] Split(int[] array)
        {
            //create 2 arrays. one is the left of array
            if (array.Length == 1) return array;

            int midPoint = array.Length / 2;
            int[] left = new int[midPoint]; //0->midpoint
            int[] right = new int[array.Length - (midPoint + 1)]; //midpoint+1 to end
          
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }
            for(int i = 0; i < right.Length; i++)
            {
                right[i] = array[left.Length + 1];
            }

            //before call happens as the stack is building
            //recursive call
            //after call is as stack is unwinding/removing

            left = Split(left);
            right = Split(right);
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int[] finished = new int[left.Length + right.Length];
            int Rcount = 0;
            int Lcount = 0;
            for(int i = 0; i < finished.Length; i++)
            {
                if (left[Lcount] > right[Rcount])
                {

                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("How many items would you like in your list");
            int InitLength = int.Parse(Console.ReadLine());
            int[] Unsorted = new int[InitLength];
            for (int i = 0; i < Unsorted.Length; i++)
            {
                Console.WriteLine("What do you want in your {0} index", i);
                Unsorted[i] = int.Parse(Console.ReadLine());
            }


            int[] sorted = Split(Unsorted);
        }
    }
}
