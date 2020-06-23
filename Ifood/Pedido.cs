namespace Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }

        public Cliente Cliente { get; set; }

        public Restaurante Restaurante { get; set; }

        public string FormaDePGTO { get; set; }

        public bool PedidoPago { get; set; }

        public string EntregarPedido(string pedido, string endereco, string cliente, string restaurante, string pgto, string pago)
        {
            return $" {cliente} obrigado por escolher o {restaurante}, Entregando o pedido{pedido} no endereço {endereco}\n Forma de Pagamento:{pgto}\n Status:{pago}";


        }
    }
}