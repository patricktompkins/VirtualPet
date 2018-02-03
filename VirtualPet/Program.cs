using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPet Ed = new MyPet();
            Ed.ProvideInformation();
            Console.WriteLine("Do you like to talk? {0}", Ed.LikesToTalk);
            bool isEndProgram = false;

            do
            {
                //tick method
                Ed.Tick();
                //place menu here

                //Enter the display output


            } while (isEndProgram);

           
        }
    }
}
