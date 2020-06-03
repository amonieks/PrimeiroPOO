namespace Calculadora
{
    public class CalcCientifica: Calc
    {
        private string[] Valores {get;set;}

        private float Soma {get;set;}

        

        public void CalcularMedia(string textoconsole){

            Resultado = 0;

            Valores = textoconsole.Split(",");

            for (int i = 0; i < Valores.Length; i++)
            {
                Soma += float.Parse(Valores[i]);

            }

            Resultado = Soma/ Valores.Length;
            
        }

        public void ControlarMetodos(string entradaUsuario){

            Valores = entradaUsuario.Split(" ");

            Numero1 = float.Parse(Valores[0]);

            Operador = Valores[1];

            Numero2 = float.Parse(Valores[2]);


            switch (Operador)
            {

                case "+":
                somar();
                break;

                case "-":
                subtrair();
                break;

                case "x":
                multiplicar();
                break;

                case "/":
                dividir();
                break;

                
                default:
                somar();
                break;
            }
        }

    }
}