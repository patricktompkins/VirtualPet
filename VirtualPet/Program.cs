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
            //Ed.ProvideInformation();
            //Console.WriteLine("Do you like to talk? {0}", Ed.LikesToTalk);
            bool isEndProgram = false;
            int endProgram = 0;

            do
            {
                //tick method
                Ed.Tick();
                //place menu here
                Console.WriteLine("Please select how you want to interact with your virtual pet?");
                Console.WriteLine("select 1, To change age.");
                Console.WriteLine("select 2, To change the type of virtural pet.");
                Console.WriteLine("select 3, To change talking status?");
                Console.WriteLine("select 4, To feed your pet.");
                Console.WriteLine("select 5, A college sports team to assign your virtual pet to be their new mascot");
                Console.WriteLine("select 6, To Exit");
                Console.WriteLine();
                Console.Write("> ");
                endProgram = int.Parse(Console.ReadLine());
                Console.WriteLine();
                



                //Enter the display output 
                Ed.LikesToTalk = true;
                if (endProgram == 1)

                {
                    Console.WriteLine("You increased age."); 
                    Ed.Age = Ed.Age + 1;
                    

                }

                else if (endProgram == 2)
                {
                    Console.WriteLine("Please enter the type of Virtual Pet.");
                    string input = Console.ReadLine();
                    Ed.PetType = input;
                    Console.WriteLine();
                    Console.WriteLine("You just set a name for your virtual pet type.");
                }

                else if (endProgram == 3)
                {
                    Console.WriteLine("Daniel, I don't like to talk because you will not feed me.");
                    Console.WriteLine("Daniel Maybe if you feed me I would like to talk you!!!!!");
                    Ed.LikesToTalk = false;
                }

                
                
                else if (endProgram == 4)
                  
                {
                    Console.WriteLine("You feed your {0} virutal", Ed.PetType);
                    Ed.HungaryLevel = Ed.HungaryLevel - 3;

                }
                
                else if( endProgram  == 5)
                {
                    Console.WriteLine("You increased age, picked another team.");
                    Ed.Age = Ed.Age + 1;
                    Ed.SelectCollegeTeam();
                    Console.WriteLine();
                    if (Ed.Age > 5)
                    {
                        Ed.Age = 0;
                    }

                }

                else if (endProgram == 6)
                {
                    Console.WriteLine("You are ending the program");
                    isEndProgram = true;
                }

                else
                {
                    
                }

                Console.WriteLine("\n\n");
            } while (!isEndProgram);

           
        }
    }
}
