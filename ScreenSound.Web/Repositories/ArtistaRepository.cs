using ScreenSound.Web.Request;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Repositories
{
    public class ArtistaRepository : IArtistaRepository
    {
        private readonly List<ArtistaResponse> _artistas =
 [
     new() { Id = 1, Nome = "Freddie Mercury", Genero = "Rock", Bio = "Vocalista da banda Queen", Albuns = 15 },
    new() { Id = 2, Nome = "Michael Jackson", Genero = "Pop", Bio = "Conhecido como o Rei do Pop", Albuns = 10 },
    new() { Id = 3, Nome = "Elis Regina", Genero = "MPB", Bio = "Uma das maiores vozes da música brasileira", Albuns = 20 },
    new() { Id = 4, Nome = "Adele", Genero = "Pop", Bio = "Cantora britânica premiada", Albuns = 4 },
    new() { Id = 5, Nome = "Metallica", Genero = "Metal", Bio = "Banda referência do Heavy Metal", Albuns = 11 },
    new() { Id = 6, Nome = "Queen", Genero = "Rock", Bio = "Banda britânica liderada por Freddie Mercury", Albuns = 15 },
    new() { Id = 7, Nome = "Iron Maiden", Genero = "Metal", Bio = "Lenda do Heavy Metal", Albuns = 17 },
    new() { Id = 8, Nome = "Nirvana", Genero = "Grunge", Bio = "Ícone do movimento grunge dos anos 90", Albuns = 3 },
    new() { Id = 9, Nome = "Pink Floyd", Genero = "Rock Progressivo", Bio = "Conhecida por álbuns conceituais", Albuns = 15 },
    new() { Id = 10, Nome = "Legião Urbana", Genero = "Rock Nacional", Bio = "Uma das maiores bandas brasileiras", Albuns = 8 },
    new() { Id = 11, Nome = "Red Hot Chili Peppers", Genero = "Rock", Bio = "Mistura rock, funk e punk", Albuns = 13 },
    new() { Id = 12, Nome = "Coldplay", Genero = "Pop Rock", Bio = "Banda britânica de sucesso mundial", Albuns = 10 },
    new() { Id = 13, Nome = "Imagine Dragons", Genero = "Alternative Rock", Bio = "Conhecida por hits internacionais", Albuns = 6 },
    new() { Id = 14, Nome = "Linkin Park", Genero = "Nu Metal", Bio = "Mistura rock, rap e música eletrônica", Albuns = 7 },
    new() { Id = 15, Nome = "Pearl Jam", Genero = "Grunge", Bio = "Banda de Seattle formada em 1990", Albuns = 12 },
    new() { Id = 16, Nome = "Bon Jovi", Genero = "Hard Rock", Bio = "Sucesso desde os anos 80", Albuns = 15 },
    new() { Id = 17, Nome = "U2", Genero = "Rock", Bio = "Banda irlandesa liderada por Bono", Albuns = 15 },
    new() { Id = 18, Nome = "The Beatles", Genero = "Rock", Bio = "Uma das bandas mais influentes da história", Albuns = 13 },
    new() { Id = 19, Nome = "AC/DC", Genero = "Hard Rock", Bio = "Clássico do rock australiano", Albuns = 18 },
    new() { Id = 20, Nome = "Foo Fighters", Genero = "Alternative Rock", Bio = "Banda formada por Dave Grohl", Albuns = 11 }
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

        public Task<bool> DeleteArtistaAsync(int id)
        {
            var removido = _artistas.RemoveAll(a => a.Id == id) > 0;
            return Task.FromResult(removido);
        }

        public Task<ArtistaResponse?> ListarArtistaPorNomeAsync(string nome)
        {
            return Task.FromResult(_artistas.FirstOrDefault(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
