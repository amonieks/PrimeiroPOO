namespace Metodos
{
    public class Carro
    {

        public string Marca { get; set; }

        public string Cor { get; set; }
        
        public int Kilometragem { get; set; }

                public Carro(){
                    
                }

                public Carro(string marca){

                    this.Marca =marca;
                }

                public Carro(string marca, string cor, int kilometro){

                    this.Marca = marca;
                    this.Cor = Cor;
                    this.Kilometragem = kilometro;
                }
        
    }
}