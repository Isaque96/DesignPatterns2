namespace DesignPatterns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        private Pedido _pedido;
        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido de {0}", _pedido.Cliente);
            _pedido.Finaliza();
        }
    }
}
