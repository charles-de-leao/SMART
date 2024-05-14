namespace SMART.Data.Entities
{
    public class OrigemModalidades
    {
        public OrigemModalidades()
        {
        }

        public OrigemModalidades(
            Guid id,
            string pais)
        {
            Id = id;
            Pais = pais;
        }

        public Guid Id { get; set; }

        public string Pais { get; set; } = string.Empty;

        public virtual ICollection<Modalidade> Modalidades { get; set; }
    }
}
