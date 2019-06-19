using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Imaging;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace SalonHabana
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();
            Uri icon = new Uri("favicon.ico", UriKind.RelativeOrAbsolute);          
           

            myFrame.Navigate(typeof(Bienvenida));
        }
        private void botonMenu_Click(object sender, RoutedEventArgs e)
        {
            splitView1.IsPaneOpen = !splitView1.IsPaneOpen;
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Bienvenida));
            boton1.IsEnabled = false;
           // menu1.Background = new SolidColorBrush(Color.FromArgb(85, 154, 119, 1));
            boton2.IsEnabled = true;
           // menu2.Background = new SolidColorBrush(Color.FromArgb(255, 191, 128, 30));

        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Reserva));
           // menu2.Background = new SolidColorBrush(Color.FromArgb(85, 154, 119, 1));
            boton1.IsEnabled = true;
            boton2.IsEnabled = false;
           // menu1.Background = new SolidColorBrush(Color.FromArgb(255, 191, 128, 30));

        }
    }
}
