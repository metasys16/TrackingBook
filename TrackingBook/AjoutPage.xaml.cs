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
    /// Logique d'interaction pour AjoutPage.xaml
    /// </summary>
    public partial class AjoutPage : Page
    {
        public AjoutPage()
        {
            InitializeComponent();
        }

        private void btnAjout_Click(object sender, RoutedEventArgs e)
        {
            AjoutLivre addBookWindow = new AjoutLivre();
            Window win = new Window();
            win.Content = addBookWindow;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        }
    }
}
