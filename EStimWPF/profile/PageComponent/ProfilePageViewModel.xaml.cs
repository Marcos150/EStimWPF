using EStimWPF.auth;
using EStimWPF.models;
using EStimWPF.profile.services;
using EStimWPF.ProfilePageComponent.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para ProfileWindow.xaml
    /// </summary>
    public partial class ProfilePageViewModel
    {
        public static bool Completed = false;
        public User usuario;
        UserService service = new UserService("perfiles");
        public ProfilePageViewModel() 
        {   
            InitializeComponent();
            Task.Run(() => FillData());
        }

        private async Task FillData()
        {
            //User[] users = await service.GetUsers();
            while (LoginPageViewModel.user == null)
            {
                Thread.Sleep(200);
            }
            Application.Current.Dispatcher.Invoke(() =>
            {
                this.usuario = LoginPageViewModel.user;
                BitmapImage bi = ImageGenerator.GenerateImage(this.usuario.ImagenB64);
                DataContext = this.usuario;
                this.gameList.ItemsSource = this.usuario.JuegosAdquiridos;
                foreach(Juego juego in usuario.JuegosAdquiridos)
                {
                    juego.Img = ImageGenerator.GenerateImage(juego.PortadaB64);
                }
                this.profilePic.Source = bi;
            });
            Completed = true;
        }
    }
}
