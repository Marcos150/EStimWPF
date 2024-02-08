using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EStimWPF.models
{
    internal class DestacadosViewModel
    {
        private string nombreJuego;
        private string infoJuego;

        public DestacadosViewModel(string nombreJuego, string infoJuego) {
            this.nombreJuego = nombreJuego;
            this.infoJuego = infoJuego;
        }

        public string NombreJuego { get => nombreJuego; set => nombreJuego = value; }
        public string InfoJuego { get => infoJuego; set => infoJuego = value; }

    }
}
