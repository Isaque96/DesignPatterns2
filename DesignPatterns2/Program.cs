using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.Cap9;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main()
        {
            //string cpf = "15585865714";
            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(Tipo.Boleto, fatura);

            //Cliente cliente = new();
            //cliente.Nome = "Isaque";
            //cliente.Endereco = "Rua Emílio de Menezes";
            //cliente.DataDeNascimento = new DateTime(1996, 1, 27);

            //string xml = new GeradorDeXML().GeraXML(cliente);

            //Console.WriteLine(xml);

            //FilaDeTrabalho filaDeTrabalho = new();
            //Pedido pedido1 = new("Mauricio", 100.0);
            //Pedido pedido2 = new("Elisana", 200.0);
            //Pedido pedido3 = new("Isabela", 300.0);
            //filaDeTrabalho.Adiciona(new PagaPedido(pedido1));
            //filaDeTrabalho.Adiciona(new PagaPedido(pedido2));
            //filaDeTrabalho.Adiciona(new PagaPedido(pedido3));
            //filaDeTrabalho.Adiciona(new FinalizaPedido(pedido1));

            //filaDeTrabalho.Processa();

            //IMensagem mensagem = new MensagemCliente("Isaque");
            //IEnviador envia = new EnviaPorSMS();
            //mensagem.Enviador = envia;
            //mensagem.Envia();

            // Método Interno do C#
            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();

            //Console.WriteLine(funcao());

            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            ////Implementação Cap 5
            //ImpressoraVisitor impressora = new();
            //soma.Aceita(impressora);

            //Historico historico = new();
            //Contrato c = new(DateTime.Now, "Isabela", TipoContrato.Novo);
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            //Console.WriteLine(historico.Pega(1).Contrato.Tipo);
            //Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            //NotasMusicais notas = new();

            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa")
            //};

            //Piano piano = new();
            //piano.Toca(musica);
        }
    }    
}