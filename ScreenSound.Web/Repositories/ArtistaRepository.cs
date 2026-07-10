using ScreenSound.Web.Request;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Repositories
{
    public class ArtistaRepository : IArtistaRepository
    {
        private readonly List<ArtistaResponse> _artistas =
        [
            new() { Id = 1, Nome = "Freddie Mercury", Genero = "Rock", Bio = "Banda de Rock", Albuns = 15 },
        new() { Id = 2, Nome = "Michael Jackson", Genero = "Pop", Bio = "Um dos maiores cantores do pop", Albuns = 10 },
        new() { Id = 3, Nome = "Elis Regina", Genero = "MPB", Bio = "Cantora Brasileira", Albuns = 20 },
        new() { Id = 4, Nome = "Adele", Genero = "Pop", Bio = "Referência Internacional", Albuns = 4 },
        new() { Id = 5, Nome = "Metallica", Genero = "Metal", Bio = "Heavy Metal", Albuns = 11 }
        ];

        public Task<ICollection<ArtistaResponse>> GetArtistasAsync()
        {
            return Task.FromResult<ICollection<ArtistaResponse>>(_artistas);
        }

        public Task<bool> AddArtistaAsync(ArtistaRequest artista)
        {
            var novoArtista = new ArtistaResponse
            {
                Id = _artistas.Any() ? _artistas.Max(a => a.Id) + 1 : 1,
                Nome = artista.Nome,
                Genero = artista.Genero,
                Bio = artista.Bio,
                Albuns = artista.Albuns
            };

            _artistas.Add(novoArtista);

            return Task.FromResult(true);
        }
    }
}
