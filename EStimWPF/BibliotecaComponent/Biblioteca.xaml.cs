using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EStimWPF.BibliotecaComponent
{
    
    public partial class Biblioteca : Page
    {

        private const string URL = "http://localhost:8080/juegos";


        private ObservableCollection<Juego> juegos = new ObservableCollection<Juego>();

        private int rows;
        public Biblioteca()
        {   
            InitializeComponent(); ;
            rows = 1;
            listaJuegos.ItemsSource = juegos;
            Task.Run(() => GetJuegos());
        }

        private async Task GetJuegos()
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(URL);
                List<Juego> obtenidos = JsonSerializer.Deserialize<List<Juego>>(json);
                int counter = 0;
                foreach (Juego juego in obtenidos)
                {
                    Application.Current.Dispatcher.Invoke(() => {
                        byte[] binaryData = Convert.FromBase64String(juego.PortadaB64);
                        juego.PortadaSource = new BitmapImage();
                        juego.PortadaSource.BeginInit();
                        juego.PortadaSource.StreamSource = new MemoryStream(binaryData);
                        juego.PortadaSource.EndInit();
                        juego.PortadaB64 = "";
                        juegos.Add(juego);
                        if(counter == 4)
                        {
                            rows++;
                        }
                        counter++;
                    });
                }
            }
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {

        }
    }
}
