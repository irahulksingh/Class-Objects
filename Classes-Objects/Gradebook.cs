using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class Gradebook
    {
        public void Grades(float Nums)
        {

            if(Nums>=95.00)
            {
                Console.WriteLine("Great Job Kid, You are :Excellent");
                Console.ReadLine();
            }
            else if (Nums<=33)
            {
                Console.WriteLine("Sorry Failed");
                Console.ReadLine();
            }

            else if (Nums > 33)
            {
                Console.WriteLine(" you have passed");
                Console.ReadLine();
            }




        }

    }
}
