using EStimWPF.models;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para GamePage.xaml
    /// </summary>
    public partial class GamePageViewModel : Page
    {
        private Juego juego;
        private int currentIndex = 0;
        private List<BitmapImage> imagePaths;

        //Constructor vacio para testing
        /*public GamePageViewModel()
        {
            InitializeComponent();
            this.DataContext = juego;
        }*/

        public GamePageViewModel()
        {
            InitializeComponent();
            this.SetJuego(CatalogoComponent.Catalogo.juego);
        }

        public void SetJuego(Juego juego)
        {
            this.juego = juego;

            BitmapImage bi = ImageGenerator.GenerateImage(juego.PortadaB64);
            this.portada.Source = bi;
            imagePaths =
            [
                ImageGenerator.GenerateImage(juego.Img1),
                ImageGenerator.GenerateImage(juego.Img2),
                ImageGenerator.GenerateImage(juego.Img3),
                ImageGenerator.GenerateImage(juego.Img4),
            ];
            this.banner.Source = imagePaths[0];

            // Temporizador del banner
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            timer.Start();

            this.DataContext = juego;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CarrouselDerecha(null, null);
        }

        public void RefrescarVista()
        {
            this.DataContext = juego;
        }

        private void CarrouselIzquierda(object sender, System.Windows.RoutedEventArgs e)
        {
            // Cambia a la anterior imagen
            currentIndex = (currentIndex + 3) % 4;
            this.banner.Source = imagePaths[currentIndex];
        }

        private void CarrouselDerecha(object sender, System.Windows.RoutedEventArgs e)
        {
            // Cambia a la siguiente imagen
            currentIndex = (currentIndex + 1) % 4;
            this.banner.Source = imagePaths[currentIndex];
        }
    }
}