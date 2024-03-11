using System.Collections.ObjectModel;

namespace EStimWPF.models
{
    public class Perfil
    {
        private string id;
        private string nombreUsuario;
        private string contrasenya;
        private string? descripcion;
        private string estado;
        private string region;
        private ObservableCollection<Juego> juegosAdquiridos;
        private string? imagenB64;

        public Perfil() { }
        public Perfil(string id, string nombreUsuario, string contrasenya
            , string descripcion, string estado, string region, 
            ObservableCollection<Juego> juegosAdquiridos, string imagenB64)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.contrasenya = contrasenya;
            this.descripcion = descripcion;
            this.estado = estado;
            this.region = region;
            this.juegosAdquiridos = juegosAdquiridos;
            this.imagenB64 = imagenB64;
        }

        public string Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Region { get => region; set => region = value; }
        public string ImagenB64 { get => imagenB64; set => imagenB64 = value; }
        public string Estado { get => estado; set => estado = value; }
        public ObservableCollection<Juego> JuegosAdquiridos { get => juegosAdquiridos; set => juegosAdquiridos = value; }
    }
}
