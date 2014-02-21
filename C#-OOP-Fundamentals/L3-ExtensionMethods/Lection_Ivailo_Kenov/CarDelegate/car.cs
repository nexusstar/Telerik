using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        public car() { MaxSpeed = 100; }
        public car(string name, int maxS, int currS)
        {
            CurrentSpeed = currS;
            MaxSpeed = maxS;
            PetName = name;
        }

        //define delegate
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listOfHandlers;
        public void RegisterWithCarEngine(CarEngineHandler methodToCall){
            listOfHandlers = methodToCall;
        }

        public void Acclerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry this car is dead");
                }
                else
                {
                    CurrentSpeed += delta;
                    if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers  != null)
                    {
                        listOfHandlers("Careful buddy! Gonna blow");
                    }
                }
            }

            if (CurrentSpeed >= MaxSpeed)
            {
                carIsDead = true;
            }
            else
            {
                Console.WriteLine("Current speed {0} ", CurrentSpeed);
            }
        }
    }
}
