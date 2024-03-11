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
        public User usuario;
        UserService service = new UserService("perfiles");
        internal ProfilePageViewModel() 
        {   
            InitializeComponent();
            Task.Run(() => FillData());
        }

        private async Task FillData()
        {
            User[] users = await service.GetUsers();

            Application.Current.Dispatcher.Invoke(() =>
            {
                this.usuario = users[0];
                BitmapImage bi = ImageGenerator.GenerateImage(this.usuario.ImagenB64);
                DataContext = this.usuario;
                this.gameList.ItemsSource = this.usuario.JuegosAdquiridos;
                this.profilePic.Source = bi;
            });
        }
    }
}
