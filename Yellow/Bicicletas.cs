namespace Yellow
{
    public class Bicicletas:Cliente
    {
        private bool Bloqueada { get; set; }

        private bool Disponivel {get; set;}

        public double Distancia { get; set; }=0;

        public double ValorCorrida {get;set;}

        


        public bool Desbloquear(){

            return true;
        }

        public bool LiberarUso(){

            return true;
        }

        public void Pedalar(){

            Distancia+= 1;
        }






    }
}