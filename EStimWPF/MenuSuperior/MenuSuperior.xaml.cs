using System.IO;
using System.Windows;
using EStimWPF.models;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace EStimWPF.MenuSuperior
{
    public partial class MenuSuperior : UserControl
    {
        private NavigationService navigationService;
        
        public MenuSuperior()
        {
            this.DataContext = new MenuSuperiorViewModel("", "CATÁLOGO", "BIBLIOTECA", "PERFIL", "SOPORTE");
            InitializeComponent();

            InsertLogoB64();
        }
        
        private void InsertLogoB64()
        {
            String logoB64 = ReadBase64String("logoenB64.txt");

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            byte[] bytes = Convert.FromBase64String(logoB64);
            
            bi.StreamSource = new MemoryStream(bytes);
            bi.EndInit();

            LogoImage.Source = bi;
        }

        private string ReadBase64String(string filePath)
        {
            try
            {
                string base64String = File.ReadAllText(filePath);
                return base64String.Trim();
            } catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
        }
        
        private void Catalogo_Click(object sender, RoutedEventArgs e)
        {
            navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(new Uri("CatalogoComponent/Busqueda.xaml", UriKind.Relative));
        }
        
        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(new Uri("BibliotecaComponent/Biblioteca.xaml", UriKind.Relative));
        }
    }
}
