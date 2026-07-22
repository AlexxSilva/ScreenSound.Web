namespace ScreenSound.Web.Request
{
    public class MusicaRequest
    {

        public string? Nome { get; set; } = string.Empty;
        public int AnoLancamento = 0;
        public int? ArtistaId { get; set; }
        public List<string>? Generos { get; set; }


    }
}
