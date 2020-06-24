namespace Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }

        public Cliente Cliente { get; set; }

        public Restaurante Restaurante { get; set; }

        public string FormaDePGTO { get; set; }

        public bool PedidoPago { get; set; }

        public string EntregarPedido()
        {

            string notafiscal = "Descrição da Entrega\n";
            
            notafiscal += Cliente.MostrarDados();
            notafiscal += Restaurante.MostrarDados();
           
            return notafiscal;


        }
    }
}