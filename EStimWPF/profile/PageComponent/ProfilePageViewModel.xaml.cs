using EStimWPF.models;
using EStimWPF.profile.services;
using EStimWPF.ProfilePageComponent.models;
using System;
using System.Collections.Generic;
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
        private User usuario;
        internal ProfilePageViewModel(User usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            DataContext = this.usuario;
            this.gameList.ItemsSource = this.usuario.JuegosAdquiridos;
        }
    }
}
