using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IinterfaceA
    {
        void execute();

    }
    public interface IinterfaceB
    {
        void execute();
    }

    public class command : IinterfaceA, IinterfaceB
    {
       

        void IinterfaceA.execute()
        {
            Console.WriteLine("interface A");
        }

        void IinterfaceB.execute()
        {
            Console.WriteLine("interface B");
        }
    }
}
