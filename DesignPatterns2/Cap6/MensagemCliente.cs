namespace DesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string _nome;
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            _nome = nome;
        }        

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o Cliente: {0}", _nome);
        }
    }
}
