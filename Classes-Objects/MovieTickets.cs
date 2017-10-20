using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class MovieTickets
    {
        public void GetAge(int Age)
        {

            //UserAge.Add(Age);
            if (Age <= 20)
                {
                Console.WriteLine("You get Kids deal = 80Kr");
            }
            else if (Age >= 65)
            {
                Console.WriteLine("You get the senior citizen deal = 90kr");
            }
            else
            {
                Console.WriteLine("You get a normal deal = 120kr");
            }

            Console.ReadLine();
       
        }
        //List<int> UserAge = new List<int>();
        
    }
    }

