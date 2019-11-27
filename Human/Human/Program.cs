using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HumanBeing jim = new HumanBeing("jim");
            HumanBeing jax = new HumanBeing("jax");
            jim.Attack(jax);
            jim.Attack(jax);
            Console.WriteLine(jax.Health);
        }
    }
}
