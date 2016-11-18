﻿using System;
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

namespace TrackingBook
{
    /// <summary>
    /// Logique d'interaction pour retourLivre.xaml
    /// </summary>
    public partial class retourLivre : Page
    {
        public retourLivre()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            PopUpRetour popUp = new PopUpRetour();
            Window winpop = new Window();
            winpop.Content = popUp;
            winpop.SizeToContent = SizeToContent.WidthAndHeight;
            winpop.ResizeMode = System.Windows.ResizeMode.NoResize;
            winpop.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            winpop.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Window).Close();
        }
    }
}
