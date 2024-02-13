using EStimWPF.models;
using System.Windows;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para Destacados.xaml
    /// </summary>
    public partial class Destacados : Window
    {
        public Destacados()
        {
            InitializeComponent();
            this.DataContext = new DestacadosViewModel("GTA 16", "Juegazo", "img1", "img2", "img3", "img4", "imgPpal");
        }
    }
}
