namespace BackendMarcador.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public int PuntosLocal { get; set; }
        public int PuntosVisitante { get; set; }
        public int CuartoActual { get; set; }
        public int FaltasLocal { get; set; }
        public int FaltasVisitante { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}