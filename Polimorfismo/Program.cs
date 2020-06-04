using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            Luigi luigi = new Luigi();

            mario.correr();
            luigi.correr();

            System.Console.WriteLine("--------------");

            mario.pular();
            luigi.pular();


        }
    }
}
