using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Splitnumbers2array
    {

        

        public void splitarray(string n)
        {
            
            if(n.Length>0)
            {

               List<string> triplets = new List<string>();
              
                for (int i = 0; i < n.Length; i ++)
                    if (i + 1 > n.Length)
                        triplets.Add(n.Substring(i));
                    else
                        triplets.Add(n.Substring(i, 1));


                for(int i=0;i< triplets.Count;i++)
               Console.WriteLine( i);

            }
        }

    }
}
