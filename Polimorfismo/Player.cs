namespace Polimorfismo
{
    public class Player
    {
        public string Nome {get;set;}


        public virtual void correr(){

            System.Console.WriteLine("Player correndo");
        }

        public virtual void pular(){

            System.Console.WriteLine("Player pulando");
        }
    }
}