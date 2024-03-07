using EStimWPF.auth;
using EStimWPF.models;
using EStimWPF.ProfilePageComponent.models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Controls;

namespace EStimWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UiWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var j = new Juego();
            j.Nombre = "Dr. Whon't";
            var list=new List<Juego>();
            list.Add(j);
            ProfilePageViewModel main = new ProfilePageViewModel(new User("J","n","","","","",list,""));
            LoginPageViewModel login = new LoginPageViewModel(main);
            mainFrame.Navigate(login);
            mainFrame.Visibility = Visibility.Visible;
            
        }

        private void AbrirVentanas(object sender, RoutedEventArgs e)
        {
            //Lista de todas las ventanas creadas. Agregad las que vayais creando aqui para que se abran al darle al boton
            /*List<Window> windows = new List<Window>
            {new Destacados(), 
            new ProfileWindow()};
            foreach(Window window in windows) 
            {
              window.Show();
            }*/

        }

        private void CerrarVentanas(object sender, RoutedEventArgs e)
        {
            foreach(Window window in Application.Current.Windows) 
            {
              window.Close();
            }
        }
    }
}