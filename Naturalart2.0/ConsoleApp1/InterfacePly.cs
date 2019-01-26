using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
       
        interface testInterface1
        {
            void Show();
        }
        interface testInterface2
        {
            void Show();
        }
       
   

    class Abc : testInterface1,
       testInterface2
    {

        void testInterface1.Show()
        {
            Console.WriteLine("For testInterface1 !!");
        }
        void testInterface2.Show()
        {
            Console.WriteLine("For testInterface2 !!");
        }
    }
}
