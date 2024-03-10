using EStimWPF.models;
using System;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using EStimWPF.BibliotecaComponent;

namespace EStimWPF.CatalogoComponent
{
    /// <summary>
    /// Lógica de interacción para Busqueda.xaml
    /// </summary>
    public partial class Busqueda : Page
    {
        private const string URL = "juegos";
        private Http<ObservableCollection<Juego>> http;
        public Busqueda()
        {
            InitializeComponent();
            http = new Http<ObservableCollection<Juego>>();
            Task.Run(() => GetJuegos());
        }

        private async Task GetJuegos()
        {
            ObservableCollection<Juego> juegos = await http.Get(URL);
            Application.Current.Dispatcher.Invoke(()=> 
            {
                foreach (Juego juego in juegos)
                {
                    juego.PortadaSource = ImageGenerator.GenerateImage(juego.PortadaB64);
                    juego.PortadaB64 = "";
                }
                listaJuegos.ItemsSource = juegos;
            });
        }

        private void GoToGamePage(object sender, SelectionChangedEventArgs e)
        {
        }

        private void NuevaVentana(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                MainWindow.navigation.Navigate(new Biblioteca());
            }
        }
    }
}
