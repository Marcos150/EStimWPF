using EStimWPF.models;
using System.Windows.Controls;

namespace EStimWPF.MenuSuperior
{
    /// <summary>
    /// Lógica de interacción para MenuSuperior.xaml
    /// </summary>
    public partial class MenuSuperior : UserControl
    {
        public MenuSuperior()
        {
            this.DataContext = new MenuSuperiorViewModel("logoEnBase64", "TIENDA", "COMUNIDAD", "ACERCA DE", "SOPORTE");
        }
    }
}
