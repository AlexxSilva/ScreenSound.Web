using ScreenSound.Web.Components.Pages;
using System.Security.Cryptography.X509Certificates;
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

        public string FotoPerfil { get; set; } = string.Empty;


        public ArtistaRequest( string nome, string genero, string bio, string fotoPerfil)
        {
            
            Nome = nome;
            Genero = genero;
            Bio = bio;
            FotoPerfil = fotoPerfil;

        }
    }
}
