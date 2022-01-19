namespace DesignPatterns2.Cap2
{
    public class Piano
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validar a compatibilidade da plataforma", Justification = "<Pendente>")]
        public void Toca(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                //Método Interno do C# com Windows de reprodução de Sons
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
