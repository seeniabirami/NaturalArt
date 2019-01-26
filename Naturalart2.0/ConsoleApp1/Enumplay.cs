using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Enumplay
    {
        public enum DayofWeek
        {
            Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

     public  void function()
        {
            string[] names = Enum.GetNames(typeof(DayofWeek));

            int num = 0;
            foreach(string s in names)
            {
                Console.WriteLine(s);
                num++;
            }
           
            Console.WriteLine("Total rec {0}", num);
            int[] tot = (int[])Enum.GetValues(typeof(DayofWeek));
            foreach(int n in tot)
            {
                Console.WriteLine(n);

            }
            Console.ReadLine();
        }
    }
}

