
namespace Yellow
{
    public class Admin:Usuario
    {
        public string IdEmpregado {get;set;}

        public string BicicletaLocal {get;set;} 


        public string Consertar(string id){

            if(id==IdEmpregado){
                
            return "Consertando Bicicleta";
            }
            return "Id incorreto, tente novamente";
        }

        public void AlocarBikes(string local){

            BicicletaLocal = local;
            
        }
    }
}