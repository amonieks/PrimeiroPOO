using System;


namespace abstracao
{
    public class Pagamento
    {
        public DateTime Data {get;set;}
        public float Valor {get;set;}


            public string Pagar(float valor){
                return "Valor Pago:"+valor;
                }

            public string cancelar(){
                return "Compra cancelada com sucesso";
            }
            
    }
}