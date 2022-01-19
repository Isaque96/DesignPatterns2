namespace DesignPatterns2.Cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string _nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            _nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a Mensagem para o Administrador: {0}", _nome);
        }
    }
}
