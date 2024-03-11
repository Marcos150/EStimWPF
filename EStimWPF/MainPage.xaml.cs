using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using EStimWPF.models;

namespace EStimWPF
{
    public partial class MainPage: Window
    {
        public MainPage()
        {
            InitializeComponent();
            
            var destacadosControl1 = new Destacados();
            var destacadosControl2 = new Destacados();
            var destacadosControl3 = new Destacados();
            var destacadosControl4 = new Destacados();
            
            CargarJuegosDestacados(frame1, destacadosControl1);
            CargarJuegosDestacados(frame2, destacadosControl2);
            CargarJuegosDestacados(frame3, destacadosControl3);
            CargarJuegosDestacados(frame4, destacadosControl4);
        }
        
        private void CargarJuegosDestacados(Frame frame, Destacados destacadosControl)
        {
            destacadosControl.DataContext = new ObservableCollection<Juego>();
            destacadosControl.DestacadosObtenidos += (juegosDestacados) => OnDestacadosLoaded(juegosDestacados, destacadosControl, frame);
        }

        private void OnDestacadosLoaded(List<Juego> juegosDestacados, Destacados destacadosControl, Frame frame)
        {
            var JuegosDestacadosLocal = destacadosControl.DataContext as ObservableCollection<Juego>;
            JuegosDestacadosLocal.Clear();
            foreach (var juego in juegosDestacados)
            {
                JuegosDestacadosLocal.Add(juego);
            }

            Console.WriteLine("JuegosDestacados: " + JuegosDestacadosLocal.Count);
            Console.WriteLine();
            Console.WriteLine("JuegosDestacados: " + JuegosDestacadosLocal[0].Nombre);
            Console.WriteLine("JuegosDestacados: " + JuegosDestacadosLocal[1].Nombre);
            Console.WriteLine("JuegosDestacados: " + JuegosDestacadosLocal[2].Nombre);
            Console.WriteLine("JuegosDestacados: " + JuegosDestacadosLocal[3].Nombre);
            Console.WriteLine();
            Console.WriteLine();
            
            frame.Content = destacadosControl;
        }
    }
}