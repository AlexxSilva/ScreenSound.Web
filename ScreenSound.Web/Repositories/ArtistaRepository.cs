using ScreenSound.Web.Response;

namespace ScreenSound.Web.Repositories
{
    public class ArtistaRepository : IArtistaRepository
    {
        public async Task<ICollection<ArtistaResponse>> GetArtistasAsync()
        {
            return await Task.FromResult(new List<ArtistaResponse>
        {
            new() { Id = 1, Nome = "Freddie Mercury", Genero = "Rock", Pais = "Reino Unido", DataNascimento = new DateTime(1946,9,5), Albuns = 15 },
            new() { Id = 2, Nome = "Michael Jackson", Genero = "Pop", Pais = "Estados Unidos", DataNascimento = new DateTime(1958,8,29), Albuns = 10 },
            new() { Id = 3, Nome = "Elis Regina", Genero = "MPB", Pais = "Brasil", DataNascimento = new DateTime(1945,3,17), Albuns = 20 },
            new() { Id = 4, Nome = "Adele", Genero = "Pop", Pais = "Reino Unido", DataNascimento = new DateTime(1988,5,5), Albuns = 4 },
            new() { Id = 5, Nome = "Metallica", Genero = "Heavy Metal", Pais = "Estados Unidos", DataNascimento = new DateTime(1981,10,28), Albuns = 11 }
        });
        }
    }
}
