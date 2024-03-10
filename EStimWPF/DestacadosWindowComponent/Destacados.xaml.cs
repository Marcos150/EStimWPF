using EStimWPF.models;
using System.Windows;
<<<<<<< HEAD
using System.Windows.Controls;
=======
>>>>>>> main

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para Destacados.xaml
    /// </summary>
<<<<<<< HEAD
    public partial class Destacados : UserControl
=======
    public partial class Destacados : Window
>>>>>>> main
    {
        public Destacados()
        {
            this.DataContext = new DestacadosViewModel("GTA 16", "Juegazo!", "img1", "img2", "img3", "img4", "imgPpal");
        }
    }
}
