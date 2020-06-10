namespace Yellow
{
    public class Pagamento:Bicicletas
    {
        private double LimiteCredito {get;set;}

        public double SaldoDebito { get; set; }

        public double Saldo { get; set; }


        public string Pagar(string formapagamento){

            switch (formapagamento)
            {
                
                case "Crédito":

                return "Pago no cartão de crédito";

                case "Débito":

                return "Pago no cartão de débito.";

                case "Saldo":

                return "Pago com saldo.";


                default:

                return "Saldo Escolha uma forma de pagamento válida";
            }
        }
    }
}