using System;
using System.Collections.Generic;


namespace LISTRAS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Cartao> cards = new List<Cartao>();

            cards.Add(new Cartao("antonio",102030,"Mastercard","10/09/2020",432));
            cards.Add(new Cartao("antonio",203040,"Visa","15/03/2023",702));
            cards.Add(new Cartao("antonio",304040,"Elo","10/07/2021",972));

            foreach (Cartao i in cards)
            {
                System.Console.WriteLine($"Titular:{i.Titular} - Bandeira: {i.Bandeira}");
            }
                        
        }
    }
}
