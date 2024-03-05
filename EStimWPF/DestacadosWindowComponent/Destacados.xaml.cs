using EStimWPF.models;
using System.Windows;
using System.Windows.Controls;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para Destacados.xaml
    /// </summary>
    public partial class Destacados : UserControl
    {
        public Destacados()
        {
            this.DataContext = new DestacadosViewModel("GTA 16", "Juegazo!", "img1", "img2", "img3", "img4", "imgPpal");
        }
    }
}
