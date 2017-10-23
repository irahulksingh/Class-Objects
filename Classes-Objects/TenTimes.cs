using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class TenTimes
    {
        private string color;
        public void TenTimesR(string sTenTimes)
        {
            for (int i = 0; i < 10; i++)
            {
                int ivalue = i + 1;

                Console.Write( ivalue + "."+ sTenTimes + ", ");
            }
            Console.ReadLine();
            }
       }
}
