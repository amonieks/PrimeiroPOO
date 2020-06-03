namespace abstracao
{
    public class Cartao:Pagamento
    {
        public string Token {get;set;}

        public string Bandeira {get;set;}

        public string Numero {get;set;}

        public string Titular {get;set;}

        public string Ccv {get;set;}




                public string ValidarToken(string token){

                    if(token == Token){

                        return "Acesso Validado";
                    }

                    return "Token Inválido";
                    
                }
    }
}