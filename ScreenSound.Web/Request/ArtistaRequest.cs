using ScreenSound.Web.Components.Pages;
using static MudBlazor.CategoryTypes;

namespace ScreenSound.Web.Request
{
    public class ArtistaRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public int Albuns { get; set; }


        public ArtistaRequest( string nome, string genero, string bio)
        {
            
            Nome = nome;
            Genero = genero;
            Bio = bio;
        }
    }
}
