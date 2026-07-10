using ScreenSound.Web.Repositories;
using ScreenSound.Web.Request;
using ScreenSound.Web.Response;

namespace ScreenSound.Web.Services
{
    public class ArtistaAPI
    {
        //private  readonly HttpClient _httpClient;
        //public ArtistaAPI(IHttpClientFactory factory)
        //{
        //    _httpClient = factory.CreateClient("API");
        //}

        private readonly IArtistaRepository _repository;

        public ArtistaAPI(IArtistaRepository repository)
        {
            _repository = repository;
        }

        public Task<ICollection<ArtistaResponse>> GetArtistasAsync()
        {
            //return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("artistas");
            return _repository.GetArtistasAsync();
        }

        public Task<bool> AddArtistaAsync(ArtistaRequest artista)
        {
            //return await _httpClient.GetFromJsonAsync<ICollection<ArtistaResponse>>("artistas");
            return _repository.AddArtistaAsync(artista);
        }


    }
}
