namespace SMART.Data.Entities
{
    public class Conteudo
    {
        public Conteudo()
        {
        }

        public Conteudo(
            Guid id,
            string nome,
            int tipo,
            Guid? grupoId)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            GrupoId = grupoId;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Tipo { get; set; }

        public Guid? GrupoId { get; set; }
    }
}
