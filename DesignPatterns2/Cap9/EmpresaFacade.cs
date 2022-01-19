namespace DesignPatterns2.Cap9
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().BuscaPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            GeraCobranca cobranca = new(tipo, fatura);
            cobranca.Emite();
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            FazContatoCliente contato = new(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
