namespace SMART.Data.Entities
{
    public class Modalidade
    {
        public Modalidade()
        {
        }

        public Modalidade(
            Guid id,
            string nome,
            Guid origemId)
        {
            Id = id;
            Nome = nome;
            OrigemId = origemId;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public Guid OrigemId { get; set; }
    }
}
