using System;
namespace encapsulamento
{
    public class Mastercard:cartao
    {
        public int Parcelas{get;set;}
        

        public void ComprarComDescontoMastercard(string Produto,float Desconto,double Valor){

            Console.WriteLine($"o produto {Produto} com desconto de {Desconto}% custará {Valor}");


        }
    }
}