namespace Heranca
{
    public class Cnpj:Pessoa
    {
        public string cnpj {get;set;}


        public bool ValidarCnpj(string cnpj)
        {
            if(cnpj!=null)
            {
                return true;
            }
            return false;
        }

        public string Numerocnpj(string cnpj){

            return cnpj;
        }
    }
}