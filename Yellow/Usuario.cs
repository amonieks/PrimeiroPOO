namespace Yellow
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }


        public bool Login(string email,string senha){

            if((email==Email)&(senha==Senha)){

                return true;
            }

            return false;
           


        }


        
    }
}