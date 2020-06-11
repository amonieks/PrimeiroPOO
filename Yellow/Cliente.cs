namespace Yellow
{
    public class Cliente:Usuario
    {
        public string Localizacao { get; set; }


        public bool Pesquisar(string localizacao){

            if(localizacao==Localizacao){

                return true;
            }

            return false;
        }


        public bool Selecionar(string resposta){

            if(resposta == "1"){

                return true;
            }

            return false;
        }
    }
}