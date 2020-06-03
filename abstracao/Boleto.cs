using System;

namespace abstracao
{
    public class Boleto: Pagamento
    {
        public DateTime Data_Vencimento {get;set;}

        public string Banco_Emissor {get;set;}
        
        public string Codigo_de_Barras {get;set;}


        public string RegistrarNOSistema(){

            return "Pagamento registrado com sucesso";
        }

        
    }
}