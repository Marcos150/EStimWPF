using EStimWPF.CatalogoComponent;
using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EStimWPF.BibliotecaComponent
{
    
    public partial class Biblioteca : Page
    {

        private const string URL = "perfiles/2";
        private Http<Perfil> http;
        private Perfil perfil;
        private Juego selectedJuego;

        private int rows = 3;
        public Biblioteca()
        {   
            InitializeComponent();
            http = new Http<Perfil>();
            if (MainWindow.perfil == null)
                Task.Run(() => GetJuegos());
            else
                listaJuegos.ItemsSource = MainWindow.perfil.JuegosAdquiridos;

        }

        private async Task GetJuegos()
        {
            {   
                MainWindow.perfil = new Perfil();
                MainWindow.perfil = await http.Get(URL);
                Application.Current.Dispatcher.Invoke(() =>
                {
                    foreach (Juego juego in MainWindow.perfil.JuegosAdquiridos)
                    {   
                        Debug.WriteLine(juego.PortadaB64);
                        byte[] binaryData = Convert.FromBase64String(juego.PortadaB64);
                        juego.PortadaSource = new BitmapImage();
                        juego.PortadaSource.BeginInit();
                        juego.PortadaSource.StreamSource = new MemoryStream(binaryData);
                        juego.PortadaSource.EndInit();
                        juego.PortadaB64 = "";
                    }
                    listaJuegos.ItemsSource = MainWindow.perfil.JuegosAdquiridos;
                });
            }
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Juego> juegos = listaJuegos.ItemsSource as ObservableCollection<Juego>;
            juegos.Remove(selectedJuego);
            Debug.WriteLine(juegos.Count);
        }
        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            selectedJuego = (listaJuegos.ItemsSource as ObservableCollection<Juego>).ToList().Find(j => j.PortadaSource == (sender as Image).Source);
            Debug.WriteLine(selectedJuego.GetType().Name);
        }

        private void NuevaVentana(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                MainWindow.navigation.Navigate(new Busqueda());
            }
                
        }
    }
}
