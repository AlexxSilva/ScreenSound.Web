namespace ScreenSound.Web.Response
{
    public class ArtistaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public int Albuns { get; set; }

    }
}
