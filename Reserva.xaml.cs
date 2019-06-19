using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace SalonHabana
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Reserva : Page
    {
        //  public List <Cliente> lista;
        
        
        public Reserva()
        {
            //   lista = new ArrayList<Cliente>();
          
            this.InitializeComponent();
            /*
 Cliente cliente1 = new Cliente();
  nombres.Text = cliente1.nombre;
            apellidos.Text = cliente1.apellido;
            dnis.Text = cliente1.dni;
            telefonos.Text = cliente1.telefono + "";
            direcciones.Text = cliente1.direccion;
            localidades.Text = cliente1.localidad;
            provincias.Text = cliente1.provincia;
            */
          //  cargarLista();
        }

        private void cargarLista()
        {/*
            lista.Add(new Cliente
            {
                nombre = "Pedro",
                apellido = "Jimenez Boza",
                dni = "48087654E",
                fechaReversa = "23/02/2019",
                password = "239897",
                username = "pedroxim",
                habitacion = "Habitacion 19",
                tarifa = 24.98
           });
            lista.Add(new Cliente
            {
                nombre = "Luisa",
                apellido = "Medina Garcia",
                dni = "49087354G",
                fechaReversa = "18/02/2019",
                password = "luiyjuan",
                username = "luisaa1991",
                habitacion = "Habitacion 25",
                tarifa = 42.60
            });
            */
            //listView1.ItemsSource = lista;
        }
        private void ListView1_ItemClick(object sender, ItemClickEventArgs e)
        {/*
            Cliente client1 = (Cliente)(e.ClickedItem);
            cliente.Text ="Nombre: "+ client1.nombre + " " + client1.apellido + "\nUsuario: "+client1.username;
            habitacion.Text = "Habitacion: " + client1.habitacion + "\nFecha de reserva: " + client1.fechaReversa;
*/
        }
        
    }
}

