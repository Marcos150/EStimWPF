using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using EStimWPF.models;
using EStimWPF.NavBarComponent.models;

namespace EStimWPF
{
    public partial class Destacados : UserControl
    {
        private const string URL = "juegos";
        private Http<List<Juego>> http;
        public List<Juego> destacados;
        public event Action<List<Juego>> DestacadosObtenidos;
        public ObservableCollection<Juego> JuegosDestacados { get; set; }
        private NavigationService navigationService;
        
        public Destacados()
        {
            InitializeComponent();
            http = new Http<List<Juego>>();
            destacados = new List<Juego>();
            DestacadosObtenidos += OnDestacadosLoaded;
            GetDestacados(); 
        }
        
        private void OnDestacadosLoaded(List<Juego> juegosDestacados)
        {
            JuegosDestacados = new ObservableCollection<Juego>(juegosDestacados);
        }
        
        private BitmapImage LoadImageFromBase64(string base64String)
        {

            if (base64String == null)
            {
                return null;
            }

            byte[] binaryData = Convert.FromBase64String(base64String);
            BitmapImage bitmapImage = new BitmapImage();

            using (MemoryStream memoryStream = new MemoryStream(binaryData))
            {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
            }

            return bitmapImage;
        }

        public async Task GetDestacados()
        {
            try
            {
                destacados = await http.Get(URL);

                if (destacados != null)
                {
                    DestacadosObtenidos?.Invoke(destacados);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        foreach (Juego juego in destacados)
                        {
                            portada.Source = LoadImageFromBase64(juego.PortadaB64);
                            portada.DataContext = juego;
                            img1.Source = LoadImageFromBase64(juego.Img1);
                            img2.Source = LoadImageFromBase64(juego.Img2);
                            img3.Source = LoadImageFromBase64(juego.Img3);
                            img4.Source = LoadImageFromBase64(juego.Img4);
                        }
                    });
                }
                else
                {
                    Console.WriteLine("No se han obtenido juegos destacados");
                }
                
                DataContext = this;
            }
            catch (Exception e) {
                Console.WriteLine("Error al obtener los juegos: " + e.Message);
            }
        }
        
        private void Game_Click(object sender, MouseButtonEventArgs e)
        {
                Image portada = (Image)sender;
                Juego juego = (Juego)portada.DataContext;
                
                navigationService = NavigationService.GetNavigationService(this);
                navigationService.Navigate(new Uri("GamePageComponent/GamePage.xaml", UriKind.Relative));
        }
    }
}
