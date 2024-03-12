using EStimWPF.models;
using System;
using System.Net.Http;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using EStimWPF.BibliotecaComponent;
using System.Diagnostics;
using System.Windows.Documents;

namespace EStimWPF.CatalogoComponent
{
    /// <summary>
    /// Lógica de interacción para Busqueda.xaml
    /// </summary>
    public partial class Catalogo : Page
    {
        private const string URL = "juegos";
        private Http<ObservableCollection<Juego>> http;
        public static Juego juego;
        public Catalogo()
        {
            InitializeComponent();
            Debug.WriteLine("catalogo");
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
                }
                listaJuegos.ItemsSource = juegos;
            });
        }

        private void GoToGamePage(object sender, SelectionChangedEventArgs e)
        {
            juego = listaJuegos.SelectedItem as Juego;
            /*NavigationService.Navigate(new GamePageViewModel(juego));*/
            Frame frame = MainPage.Frames.Find((f) => f.Name == "GamePage");
            frame.Source = new Uri("GamePageComponent/GamePage.xaml", UriKind.Relative);
            Navigator.Navigate(MainPage.Frames, "GamePage");
        }
    }
}
