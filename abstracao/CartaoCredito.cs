namespace abstracao {
    public class CartaoCredito : Cartao {


        public double Limite { get; set; }

        public void AumentarLimite (float acrescimo) {

                

            if ((Limite + acrescimo) >= 5000) {
                string texto = "Seu limite pré-aprovado é de até 5000, para valores superiores é necessário contato com a central, Phone:4848-2500";
                System.Console.WriteLine(texto);
            } else {
                Limite = Limite + acrescimo;

            }
        }

        public string Bloquer () {

            return "Cartão bloqueado com sucesso";
        }

    }
}