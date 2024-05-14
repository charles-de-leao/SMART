namespace SMART.Data.Entities
{
    public class Livro
    {
        public Livro()
        {
        }

        public Livro(
            Guid id,
            string titulo,
            string autor)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
        }

        public Guid Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Autor { get; set; } = string.Empty;
    }
}
