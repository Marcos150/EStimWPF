using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EStimWPF.models
{
    internal class DestacadosViewModel
    {
        private string nombreJuego;
        private string infoJuego;
        private string img1, img2, img3, img4, imgPpal;

        public DestacadosViewModel(string nombreJuego, string infoJuego, string img1, string img2, string img3, string img4, string imgPpal) {
            this.nombreJuego = nombreJuego;
            this.infoJuego = infoJuego;
            this.img1 = img1;
            this.Img2 = img2;
            this.Img3 = img3;
            this.Img4 = img4;
            this.ImgPpal = imgPpal;
        }

        public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
        public string InfoJuego { get => infoJuego; set => infoJuego = value; }
        public string Img { get => img; set => img = value; }
        public string Img2 { get => img2; set => img2 = value; }
        public string Img3 { get => img3; set => img3 = value; }
        public string Img4 { get => img4; set => img4 = value; }
        public string ImgPpal { get => imgPpal; set => imgPpal = value; }
    }
}
