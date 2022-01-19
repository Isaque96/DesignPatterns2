namespace DesignPatterns2.Cap7
{
    public class PagaPedido : IComando
    {
        private Pedido _pedido;
        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando o pedido de {0}", _pedido.Cliente);
            _pedido.Paga();
        }
    }
}
