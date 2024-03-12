using EStimWPF.auth;
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
            while (LoginPageViewModel.user == null && !ProfilePageViewModel.Completed)
            {
                Thread.Sleep(200);
            }
            Application.Current.Dispatcher.Invoke(() =>
            {
                foreach (Juego juego in LoginPageViewModel.user.JuegosAdquiridos)
                {
                    juego.PortadaSource = ImageGenerator.GenerateImage(juego.PortadaB64);
                }
                listaJuegos.ItemsSource = LoginPageViewModel.user.JuegosAdquiridos;
            });
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            LoginPageViewModel.user.JuegosAdquiridos.Remove(selectedJuego);
        }
        private void ImageClick(object sender, MouseButtonEventArgs e)
        {
            selectedJuego = (LoginPageViewModel.user.JuegosAdquiridos).ToList().Find(j => j.PortadaSource == (sender as Image).Source);
        }

        private void PassScroll(object sender, MouseWheelEventArgs e)
        {
            Debug.WriteLine("hola");
        }
    }
}
