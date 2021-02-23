using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();

            machine.TurnOn();
            machine.AddFilter(0);
            machine.Brew();
            machine.TurnOff();
        }
    }
}
