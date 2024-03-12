using EStimWPF.models;
using EStimWPF.profile.services;
using EStimWPF.ProfilePageComponent.models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EStimWPF.auth
{
    /// <summary>
    /// Lógica de interacción para LoginPage.xaml
    /// </summary>
    public partial class LoginPageViewModel : Page
    {
        UserService service = new UserService("perfiles");
        event EventHandler<LoginPageViewModel> OnLoginPage;
        public static User user;
        public LoginPageViewModel()
        {
            InitializeComponent();
        }
        private async void LogIn(object sender, EventArgs e)
        {
            User[] users= await service.GetUsers();
            user=users[0];
            if (user.NombreUsuario==this.txt_login.Text && user.Contrasenya==this.txt_password.Text)
            {
                Navigator.Login(MainPage.Frames, "frame1 frame2 frame3 frame4 nav menu");
            }
        }

    }
}
