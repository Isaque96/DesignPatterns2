namespace DesignPatterns2.Cap6
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a Mensagem por SMS");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
