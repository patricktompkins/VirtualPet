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

        //Constructors
        public MyPet()
        {
            this.petType = "Mr. Ed The Talking Horse";
            this.age = 3;
            this.likesToTalk = true;
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
        private void Tick()
        {
            //Need to fill in Tick Method

        }










    }
}
