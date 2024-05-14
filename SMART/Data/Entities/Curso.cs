namespace SMART.Data.Entities
{
    public class Curso
    {
        public Curso()
        {
        }

        public Curso(
            Guid id,
            string nome,
            string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;
    }
}
