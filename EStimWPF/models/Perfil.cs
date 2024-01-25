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
        private Estado estado;

    }
    enum Estado
    {
        Desconectado,
        Conectado,
        Ausente
    }
}
