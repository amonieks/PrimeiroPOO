namespace PrimeiroPOO
{
    public class smartphone
    {
        public string cor;

        public string modelo;

        public float tamanho;

        public bool ligado=true;


        public string ligadesliga(){

            
           
            if(ligado==false){

                return "Good bye ;-)";
            }else
            {
                return "Hello Moto!!";
            }

        }

        public string chamada(){

            return "chamada em andamento";
        }
        
        public string mensagem(){

            return "Mensagem enviada";

        }
    }

        

   
}