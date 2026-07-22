namespace ScreenSound.Web.Response
{
    public class MusicaResponse
    {
        public string? Nome { get; set; } = string.Empty;
        public int AnoLancamento = 0;
        public int? ArtistaId { get; set; }
        public List<string>? Generos { get; set; }

    }
}
