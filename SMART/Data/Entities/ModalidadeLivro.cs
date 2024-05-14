namespace SMART.Data.Entities
{
    public class ModalidadeLivro
    {
        public ModalidadeLivro()
        {
        }

        public ModalidadeLivro(
            Guid id,
            Guid modalidadeId,
            Guid livroId)
        {
            Id = id;
            ModalidadeId = modalidadeId;
            LivroId = livroId;
        }

        public Guid Id { get; set; }

        public Guid ModalidadeId { get; set; }

        public Guid LivroId { get; set; }
    }
}
