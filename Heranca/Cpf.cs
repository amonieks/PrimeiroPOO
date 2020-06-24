namespace Heranca
{
    public class Cpf:Pessoa
    {
        public string cpf {get; set;}

        public string Rg {get;set;}


        public bool ValidarCpf(string cpf){

            if(cpf != null){

                return true;
            }

            return false;
        }

        public string NumeroCpf(string cpf)
        {
            return cpf;
        }

    }
}