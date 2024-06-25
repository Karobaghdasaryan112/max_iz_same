using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = {1,1,2,2,1,1,3,3,4,5,1,1};
            int[] Count = new int[array.Length];
            int count;
            int index = 0;
            Array.Sort(array);
            List<string> list = new List<string>();
            foreach (var item in array)
            {
                list.Add(item.ToString());
            }
            for(int i = 0; i < list.Count; i++)
            {
                count = list.LastIndexOf(list[i]) - list.IndexOf(list[i]) + 1;
                i = list.LastIndexOf(list[i]);
                Count[index] = count;
                index++;
            }
            foreach (var item in Count)
            {
                if(item !=0)
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(Count.Max());
            Console.ReadLine();
        }
    }
}
