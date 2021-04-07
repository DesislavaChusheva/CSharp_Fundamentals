using System;
using System.Linq;

namespace _07.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
            int counter = 0;
            int longestSequenceItem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currCount = 1;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currCount ++;
                        if (currCount>counter)
                        {
                            counter = currCount;
                            longestSequenceItem = array[i];
                        }
                    }
                    else
                    {
                        currCount = 0;
                        break;
                    }
                }
            }
            for (int i = 1; i < counter; i++)
            {
                Console.Write(longestSequenceItem +" ");
            }
        }
    }
}
