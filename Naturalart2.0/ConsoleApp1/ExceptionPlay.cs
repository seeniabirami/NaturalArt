using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public   class  ExceptionPlay
    {

        public   void function()
        {
            int x = 0;
            int div = 0;
            try
            {

                try
                {
                    div = 100 / x;
                    Console.WriteLine("Not executed line");
                }
                catch (DivideByZeroException de)
                {
                    Console.WriteLine(" Inner DivideByZeroException");
                }
                catch (Exception ex) {
                    Console.WriteLine("Inner Exception");
                }
                finally
                {
                    Console.WriteLine("inner Finally Block");
                }
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(" outer DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("outer Exception");
            }
            finally
            {
                Console.WriteLine("outer Finally Block");
            }
            Console.WriteLine("Result is {0}", div);

            Console.ReadLine();
        }
    }

}
