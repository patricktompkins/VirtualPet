using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class MyPet
    {
        //fields 
        private string petType;
        private int age;
        private bool likesToTalk;
        private int hungaryLevel;
        private string collegeTeam;

        //properties
        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        public int Age
        {
            get { return this.age;  }
            set { this.age = value; }
        }

        public bool LikesToTalk
        {
            get { return this.likesToTalk; }
            set { this.likesToTalk = value; }
        }


        public int HungaryLevel
        {
            get { return this.hungaryLevel; }
            set { this.hungaryLevel = value; }
        }

        public string NccaTeam
        {
            get { return this.collegeTeam; }
            set { this.collegeTeam = value; }
        }

        //Constructors
        public MyPet()
        {
            this.petType = "Horse";
            this.age = 0;
            this.likesToTalk = true;
            this.hungaryLevel = 12;
            this.collegeTeam = "Not Selected";
        }  // Do we need overriding constructors

        //Methods

        public void TalkToThePet()
        {
           if (likesToTalk)
            {
                Console.WriteLine("Yes I like to talk.");
            }
            else
            {
                Console.WriteLine("No I don't like to talk");
            }
           
        }

        public void ProvideInformation()
        {
            Console.WriteLine("I am a {0} years old {1} that {2} to talk.", age, petType, likesToTalk);
        }

        public void AskQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    Console.WriteLine(age);
                    break;

                case 2:
                    Console.WriteLine(likesToTalk);
                    break;
                case 3:
                    Console.WriteLine(petType);
                    break;

                default:
                    break;


            }
        }

        public void SelectCollegeTeam()
        {
            switch (age)
            {
                case 1:
                    collegeTeam = "The 2017 NCAA Footaball National Champions Alabama Crimson Tide";
                    Console.WriteLine("The 2017 NCAA Footaball National Champions Alabama Crimson Tide");
                    break;

                case 2:
                    collegeTeam = "Ohio State Buckeyes";
                    Console.WriteLine("Ohio State Buckeyes");
                    break;
                case 3:
                    collegeTeam = "Florida Gators";
                    Console.WriteLine("Florida Gators");
                    break;

                case 4:
                    collegeTeam = "Norte Dame Fighting Irish";
                    Console.WriteLine("Norte Dame Fighting Irish");
                    break;

                default:
                    collegeTeam = "The 2017 NCAA Footaball National Champions Alabama Crimson Tide";
                    Console.WriteLine("The 2017 NCAA Footaball National Champions Alabama Crimson Tide");
                    break;


            }

            

        }


        //TICK METHOD
        public void Tick()
        {
            string level;
            string speak;
            

            HungaryLevel = HungaryLevel + 1;
            
            
            Console.WriteLine("I am Mr. Ed the talking {0}.", PetType );
            Console.WriteLine("I am {0} years old.", Age);
            if (LikesToTalk )
            {
             speak = "like to talk";
            }
            else
            {

            speak = "do not like to talk";
            }
            Console.WriteLine("I {0} all the time.", speak);
            
            if (HungaryLevel < 10)
            {
                level = "I am not hungary.";
            }
            else 
            {
                level = "I am hungary.";
            }
            Console.WriteLine(level);
            Console.WriteLine("The team is {0} ", collegeTeam);

            Console.WriteLine();
        }










    }
}
