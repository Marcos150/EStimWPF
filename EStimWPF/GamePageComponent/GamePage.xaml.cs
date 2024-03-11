using EStimWPF.models;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para GamePage.xaml
    /// </summary>
    public partial class GamePageViewModel : Page
    {
        private Juego juego;

        //Constructor vacio para testing
        public GamePageViewModel()
        {
            InitializeComponent();
            this.juego = new Juego();
            juego.Nombre = "Me gusta el queso";

            this.DataContext = juego;
        }

        public GamePageViewModel(Juego juego)
        {
            InitializeComponent();
            this.SetJuego(juego);
        }

        public void SetJuego(Juego juego)
        {
            this.juego = juego;

            byte[] binaryData = Convert.FromBase64String(juego.PortadaB64);

            BitmapImage bi = new();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(binaryData);
            bi.EndInit();

            this.portada.Source = bi;
            this.banner.Source = bi;

            this.DataContext = juego;
        }

        public void RefrescarVista()
        {
            this.DataContext = juego;
        }
    }
}