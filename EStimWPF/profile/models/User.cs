using EStimWPF.models;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Windows.Media.Imaging;

namespace EStimWPF.ProfilePageComponent.models
{
    public class User : INotifyPropertyChanged
    {
        private string id;
        private string nombreUsuario ;
        private string contrasenya;
        private string descripcion ;
        private string estado ;
        private string region;
        private List<Juego> juegosAdquiridos;
        private string imagenB64;
        
        public User()
        {
            
        }
        public User(string id, string nombreUsuario, string contrasenya
            , string descripcion, string estado, string region,
            List<Juego> juegosAdquiridos, string imagenB64)
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


        public void RaisedPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set { nombreUsuario = value; RaisedPropertyChanged("NombreUsuario"); } }
        public string Contrasenya { get => contrasenya; set { contrasenya = value; RaisedPropertyChanged("Contrasenya"); } }
        public string Descripcion { get => descripcion; set {descripcion = value; RaisedPropertyChanged("Descripcion");} }
        public string Region { get => region; set { region = value; RaisedPropertyChanged("Region"); } }
        public string ImagenB64 { get => imagenB64; set{imagenB64 = value; RaisedPropertyChanged("ImagenB64");} }
        public string Estado { get => estado; set {estado = value; RaisedPropertyChanged("Estado");} }
        public List<Juego> JuegosAdquiridos { get => juegosAdquiridos; set => juegosAdquiridos = value; }
        public BitmapImage PortadaSource { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }


}
