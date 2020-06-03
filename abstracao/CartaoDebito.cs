namespace abstracao
{
    public class CartaoDebito:Cartao
    {
        public float Saldo {get;set;}




        public string Transferir(float valor){

            if(valor>0){

                return "Valor total transferido de "+valor;
            }

            return "Saldo insuficiente";
        }


        public string PagarTitulo(double valortitulo, double saldo){

            if(valortitulo<saldo){

                return "Pagamento realizado com sucesso";
            }

            return "Saldo insuficiente para pagamento deste boleto";
        }


    }
}