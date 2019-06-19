using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Windows.Input;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace SalonHabana
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Formulario : Page
    {

        Cliente client1 = new Cliente();

        Reserva mireserva = new Reserva();

        public Formulario()
        {
            this.InitializeComponent();
            ScrollViewer sv = new ScrollViewer();
            sv.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            elgrid.Children.Add(sv);
        }




        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            client1.nombre = tbnombre.Text;
            client1.apellido = tbapellidos.Text;
            client1.dni = tbdni.Text;
            client1.direccion = tbdireccion.Text;
            client1.localidad = tblocalidad.Text;
            client1.provincia = tbprovincia.Text;
            client1.telefono = Int32.Parse(tbtelefono.Text);            

            this.Frame.Navigate(typeof(Reserva));

        }
        /*
                private void selecciono(object sender, SelectionChangedEventArgs e)
                {
                    ComboBoxItem item = (ComboBoxItem)cbhabitacion.SelectedItem;
                    String seleccionado = item.Content.ToString();

                    if (seleccionado == "Habitacion 211")
                    {
                        tbtarifa.Text= "56.90";
                    }
                    else if (seleccionado == "Habitacion 237")
                    {
                        tbtarifa.Text = "78.40";
                    }

                }
                */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Bienvenida));

        }



    }

}

