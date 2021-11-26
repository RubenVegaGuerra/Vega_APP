using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VegaWPF.LogicaNegocio;

namespace VegaWPF
{

    //PANTALLA DEL CARRITO
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            actualizarPrecio();



        }


        private void btComprar_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Sneaker> CarritoVacio = new List<Sneaker>();

            Window3 w3 = this;
            w3.DataGridCarrito.ItemsSource = CarritoVacio;


        }

        public void actualizarPrecio()
        {

        }
    }
}
