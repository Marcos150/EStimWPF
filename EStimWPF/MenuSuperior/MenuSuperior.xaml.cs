using System.Windows;
using EStimWPF.models;
using System.Windows.Controls;
using EStimWPF.CatalogoComponent;
using System.Windows.Navigation;

namespace EStimWPF.MenuSuperior
{
    public partial class MenuSuperior : UserControl
    {
        public MenuSuperior()
        {
            this.DataContext = new MenuSuperiorViewModel("logoEnBase64", "CATÁLOGO", "BIBLIOTECA", "PERFIL", "SOPORTE");
        }

        private void Perfil_Click(object sender, RoutedEventArgs e)
        {
            Navigator.Navigate(MainPage.Frames, "perfil");
        }
        
        private void Catalogo_Click(object sender, RoutedEventArgs e)
        {
            Navigator.Navigate(MainPage.Frames, "Catalogo");
        }
        
        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            Navigator.Navigate(MainPage.Frames, "Biblioteca");
        }
    }
}
