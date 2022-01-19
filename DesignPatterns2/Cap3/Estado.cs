namespace DesignPatterns2.Cap3
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado (Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
