using ScreenSound.Web.Response;

namespace ScreenSound.Web.Repositories
{
    public interface IArtistaRepository
    {
        Task<ICollection<ArtistaResponse>> GetArtistasAsync();
    }
}
