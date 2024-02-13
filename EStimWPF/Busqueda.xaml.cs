using EStimWPF.models;
using System;
using System.Net.Http;
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
using System.Diagnostics;
using System.Text.Json;

namespace EStimWPF
{
    /// <summary>
    /// Lógica de interacción para Busqueda.xaml
    /// </summary>
    public partial class Busqueda : Page
    {
        ObservableCollection<Juego> juegos = new ObservableCollection<Juego>();
        private const string URL = "http://localhost:8080/juegos";
        public Busqueda()
        {
            InitializeComponent();
            listaJuegos.ItemsSource = juegos;
            Task.Run(() => GetJuegos(juegos));
        }

        private async Task GetJuegos(ObservableCollection<Juego> listita)
        {

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(URL);
                List<Juego> obtenidos = JsonSerializer.Deserialize<List<Juego>>(json);
                foreach(Juego juego in obtenidos)
                {
                    Debug.WriteLine(juego.nombre);
                    Application.Current.Dispatcher.Invoke(() => listita.Add(juego));
                }
            }
        }
    }
}
