using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class Machine
    {
        private bool isTurnedOn = false;

        protected bool IsTurnedOn
        {
            get { return isTurnedOn; }
            set { isTurnedOn = value; }
        }
        private bool isDone;

        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }


        public Machine()
        {

        }

        public string AddWater()
        {
            return "Added water to machine";
        }

        public void AddFilter(int amountOfFilters)
        {
            for (int i = 0; i < amountOfFilters; i++)
            {
                Filter filter = new Filter();
            }
        }

        public void Brew()
        {
            isDone = false;
            
            isDone = true;
        }


        public string TurnOn()
        {
            IsTurnedOn = true;
            return "Machine is now on";
        }

        public string TurnOff()
        {
            IsTurnedOn = false;
            return "Machine is now off";
        }

    }
}
