using ScreenSound.Web.Request;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Repositories
{
    public interface IArtistaRepository
    {
        Task<bool> AddArtistaAsync(ArtistaRequest artista);
        Task<ICollection<ArtistaResponse>> GetArtistasAsync();
        Task<bool> DeleteArtistaAsync(int id);
        Task<ArtistaResponse?> ListarArtistaPorNomeAsync(string nome);
    }
}
