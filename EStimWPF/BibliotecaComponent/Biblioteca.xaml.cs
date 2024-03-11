using EStimWPF.CatalogoComponent;
using EStimWPF.models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            Task.Run(() => GetJuegos());
        }

        private async Task GetJuegos()
        {
            perfil = await http.Get(URL);
            Application.Current.Dispatcher.Invoke(() =>
            {
                foreach (Juego juego in perfil.JuegosAdquiridos)
                {
                    juego.PortadaSource = ImageGenerator.GenerateImage(juego.PortadaB64);
                    juego.PortadaB64 = "";
                }
                listaJuegos.ItemsSource = perfil.JuegosAdquiridos;
            });
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

        private void PassScroll(object sender, MouseWheelEventArgs e)
        {
            Debug.WriteLine("hola");
        }
    }
}
