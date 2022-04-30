namespace EAgenda.Dominio.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int id;

        public abstract ResultadoValidacao Validar();
    }
}
