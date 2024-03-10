<<<<<<< HEAD
﻿using System.Windows.Controls;
using EStimWPF.NavBarComponent.models;
=======
﻿using EStimWPF.models;
using EStimWPF.NavBarComponent.models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
>>>>>>> main

namespace EStimWPF.NavBarComponent
{
    /// <summary>
    /// Lógica de interacción para navBar.xaml
    /// </summary>
    public partial class navBar : UserControl
    {
        public navBar()
        {
<<<<<<< HEAD
            this.DataContext = new navBarViewModel("Tu tienda", "Nuevo y destacable", "Categorías", "Tienda de puntos", "Noticias", "Laboratorios");
=======
            this.DataContext = new navBarViewModel("link1", "link2", "link3", "link4", "link5", "link6");
>>>>>>> main
            InitializeComponent();
        }
    }
}
