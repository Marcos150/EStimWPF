﻿using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Lógica de interacción para Destacados.xaml
    /// </summary>
    public partial class Destacados : Window
    {
        public Destacados()
        {
            InitializeComponent();
            this.DataContext = new DestacadosViewModel("GTA 16", "Juegazo");
        }

        private void prueba(object sender, EventArgs args)
        {

        }
    }
}
