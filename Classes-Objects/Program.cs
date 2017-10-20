using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Please  enter an age");
            MovieTickets mTicket = new MovieTickets();
            int uAge = int.Parse(Console.ReadLine());
            mTicket.GetAge(uAge);

            Console.WriteLine("2. Enter a word to be repeated 10 times ?");
            TenTimes sTenT = new TenTimes();
            string sWord = Console.ReadLine();
            sTenT.TenTimesR(sWord);


            Console.WriteLine("Enter the marks obtained by the student and his/her name");
            Gradebook student = new Gradebook();
            float fMarks = float.Parse(Console.ReadLine());
            student.Grades(fMarks);



     
        }
    }
}
