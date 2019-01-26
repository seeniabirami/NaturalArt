using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IinterfaceA cmd = new command();
            cmd.execute();

            IinterfaceB cmd2 = new command();
            cmd2.execute();
            Console.ReadLine();
        }



        public void splitnumbers()
        {
            string n = "123456789";

            Splitnumbers2array s = new Splitnumbers2array();
            s.splitarray(n);
            Console.ReadLine();
    }


    }

   
    class Baseclass
    {
        int i;
        public Baseclass(int ii)
        {
            i = ii;
            Console.Write("Base ");
        }
    }
    class Derived : Baseclass
    {
        public Derived(int ii) : base(ii)
        {
            Console.Write("Derived ");
        }
    }

}


    //static void Main(string[] args)
    //{
    //    PartialClassplay obj = new PartialClassplay();
    //    obj.function1();
    //    obj.function2();
    //    Console.ReadLine();
    //}
    //static void Main(string[] args)
    //{
    //    testInterface1 obj1 = new Abc();
    //    obj1.Show();
    //    testInterface2 obj2 = new Abc();
    //    obj2.Show();
    //    Console.ReadLine();
    //}