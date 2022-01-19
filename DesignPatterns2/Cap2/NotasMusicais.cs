namespace DesignPatterns2.Cap2
{
    internal class NotasMusicais
    {
        private static IDictionary<string, INota> notas = new Dictionary<String, INota>()
        {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() }
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}
