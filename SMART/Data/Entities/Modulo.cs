namespace SMART.Data.Entities
{
    public class Modulo
    {
        public Guid Id { get; set; }

        public Guid CursoId { get; set; }
        
        public int Numero {get; set; }

        public int CargaHoraria { get; set; }
    }
}
