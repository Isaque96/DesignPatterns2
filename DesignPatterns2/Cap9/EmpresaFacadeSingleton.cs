namespace DesignPatterns2.Cap9
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new();
        public EmpresaFacade Instancia
        {
            get { return facade; }
        }
    }
}
