namespace SMART.Data.Entities
{
    public class GrupoConteudo
    {
        public GrupoConteudo()
        {
        }

        public GrupoConteudo(
            Guid id,
            string nome,
            Guid modalidadeId)
        {
            Id = id;
            Nome = nome;
            ModalidadeId = modalidadeId;
        }

        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public Guid ModalidadeId { get; set; }
    }
}
