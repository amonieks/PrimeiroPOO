namespace Polimorfismo
{
    public class Luigi:Player
    {
        public override void correr(){

            System.Console.WriteLine("luigi está correndo");

            
        }

        public override void pular(){

            base.pular();

            System.Console.WriteLine("Luigi pulou mais 20%");
        }
    }
}