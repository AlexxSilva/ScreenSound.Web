namespace ScreenSound.Web.Response
{
    public class ArtistaResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public int Albuns { get; set; }

        public string FotoPerfil { get; set; }  
    }
}
