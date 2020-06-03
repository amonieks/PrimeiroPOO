namespace Calculadora
{
    public class Calc
    {


        public float Numero1 {get;set;}

        protected string Operador{get;set;}

        public float Numero2 {get;set;}

        public float Resultado{get;set;}


                public void somar(){

                    Resultado = 0;
                    Resultado = Numero1+Numero2;
                }

                public void subtrair(){

                    Resultado = 0;
                    Resultado = Numero1-Numero2;
                }

                public void multiplicar(){

                    Resultado = 0;
                    Resultado = Numero1*Numero2;
                }

                public void dividir(){

                    Resultado = 0;
                    Resultado = Numero1/Numero2;
                }



        
        
    }
}