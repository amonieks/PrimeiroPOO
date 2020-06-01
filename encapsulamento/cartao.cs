namespace encapsulamento
{
    public class cartao
    {
        public string Nome {get;set;}

        public string Numero {get; set;}

        private string Token {get; set;}

        protected int Cvc {get; set;}



            public string AprovarCompra(){
                    return "Compra aprovada";
            }


            private bool ValidarToken(){

                    return true;

                
            }

            protected bool ValidarCompra(){
                    return true;

            }


            

            

                      
            



    }
}