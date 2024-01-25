using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStimWPF.models
{
    class Perfil
    {
        private string id;
        private string nombreUsuario;
        private string contrasenya;
<<<<<<< HEAD
        private string descripcion;
        private Estado estado;
        private string region;
        private List<Juego> juegosAdquiridos;
        private string imagenB64;

        public Perfil(string id, string nombreUsuario, string contrasenya
            , string descripcion, Estado estado, string region, 
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

        public string Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenya { get => contrasenya; set => contrasenya = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Region { get => region; set => region = value; }
        public string ImagenB64 { get => imagenB64; set => imagenB64 = value; }
        internal Estado Estado { get => estado; set => estado = value; }
        internal List<Juego> JuegosAdquiridos { get => juegosAdquiridos; set => juegosAdquiridos = value; }
=======
        private Estado estado;

>>>>>>> f2c99b0050d509be5520a6d7514413890e4dcc38
    }
    enum Estado
    {
        Desconectado,
        Conectado,
        Ausente
    }
}
