using EStimWPF.models;
using System.ComponentModel;
using Wpf.Ui.Controls;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para GamePage.xaml
    /// </summary>
    public partial class GamePageViewModel : UiPage, INotifyPropertyChanged
    {
        private Juego juego;
        public GamePageViewModel()
        {
            InitializeComponent();
            this.juego = new Juego();
            juego.Nombre = "a";
            

            this.DataContext = juego;
        }

        public void SetJuego(Juego juego)
        {
            this.juego = juego;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
