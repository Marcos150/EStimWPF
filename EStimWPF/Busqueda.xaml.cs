using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para Busqueda.xaml
    /// </summary>
    public partial class Busqueda : Page
    {
        ObservableCollection<Juego> juegos = new ObservableCollection<Juego>();
        public Busqueda()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                juegos.Add(new Juego("Juego" + i, "Desarrollador"));
            }
            listaJuegos.ItemsSource = juegos;
        }

        private void CambiarNombre(object sender, RoutedEventArgs e)
        {
            juegos[0].Nombre = "jueguito";
            juegos.Add(new Juego("Juegaaaso", "dessa"));
        }
    }
}
