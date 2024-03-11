using System.Windows;
using EStimWPF.models;
using System.Windows.Controls;

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
            ProfileWindow profileWindow = new ProfileWindow();
            profileWindow.Show();
        }
        
        private void Catalogo_Click(object sender, RoutedEventArgs e)
        {
            //Busqueda busqueda = new Busqueda();
            //busqueda.Show();
        }
        
        private void Biblioteca_Click(object sender, RoutedEventArgs e)
        {
            //Biblioteca biblioteca = new Biblioteca();
            //biblioteca.Show();
        }
    }
}
