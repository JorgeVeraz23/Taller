namespace VeraZambrano.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public String clave { get; set; }
        public Boolean estado { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

    }
}
