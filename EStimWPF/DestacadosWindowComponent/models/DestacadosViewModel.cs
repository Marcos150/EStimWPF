using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EStimWPF.models
{
    internal class DestacadosViewModel
    {
        private string nombreJuego;
        private string infoJuego;
        private string portadaB64;
        private string[] imagenes = new string[4];
        
        public DestacadosViewModel(string nombreJuego, string infoJuego, string img1, string img2, string img3, string img4, string portadaB64) {
            this.nombreJuego = nombreJuego;
            this.infoJuego = infoJuego;
            this.portadaB64 = portadaB64;
            imagenes[0] = img1;
            imagenes[1] = img2;
            imagenes[2] = img3;
            imagenes[3] = img4;
        }

        public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
        public string InfoJuego { get => infoJuego; set => infoJuego = value; }
        public string Img1 { get => imagenes[0]; set => imagenes[0] = value; }
        public string Img2 { get => imagenes[1]; set => imagenes[1] = value; }
        public string Img3 { get => imagenes[2]; set => imagenes[2] = value; }
        public string Img4 { get => imagenes[3]; set => imagenes[3] = value; }
        public string PortadaB64{ get => portadaB64; set => portadaB64 = value; }
    }
}
