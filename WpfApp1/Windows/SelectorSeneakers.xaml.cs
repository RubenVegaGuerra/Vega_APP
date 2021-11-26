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
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    /// 

    public partial class Window2 : Window
    {

        //CREO EL CARRITO
        private static List<Sneaker> Carrito = new List<Sneaker>();
        public ComboBoxItem cbiUtil = new ComboBoxItem();

        public Window2()
        {
            InitializeComponent();
            this.DataContext = this;
            //Poner las marcas principales
            Logica.PonerMarcas(ComboBoxMarca);

        }

        //Cuando Cambia la Marca
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)ComboBoxMarca.SelectedItem;
            String s = "";
            s = cbi.Content.ToString();
            lblMarca.Content = s;
            //APLICAR IMAGEN
            Logica.ImagenMarca(lblMarca, lblImage);
            //ACTUALIZAR LOS MODELOS
            Logica.Comprobar(lblMarca.Content.ToString(), ComboBoxModelo);
        }


        //Cuando Cambia el Modelo
        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi2 = (ComboBoxItem)ComboBoxModelo.SelectedItem;
            String s2 = "";
            s2 = cbi2.Content.ToString();
            lblModelo.Content = s2;
            //APLICAR IMAGEN
            Logica.ImagenModelo(lblModelo, lblImage);
            //COMPROBAR EL PRECIO
            Logica.Precio(lblModelo, lblPrecio);
        }




        //Botón de Refrescar
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = this;
            w2.Close();

            Window2 w22 = new Window2();
            w22.Show();

        }

        //Boton para agregar al carrito
        private void btComprar_Click(object sender, RoutedEventArgs e)
        {
            Carrito.Add(new Sneaker(lblMarca.Content.ToString(), lblModelo.Content.ToString(), lblPrecio.Content.ToString()));
            Window3 w3 = new Window3();
            w3.DataGridCarrito.ItemsSource = Carrito;
            MessageBox.Show("Producto añadido al carrito");

        }



        //Botón ver el carrito
        private void btVerCarro(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.DataGridCarrito.ItemsSource = Carrito;
            w3.Show();
        }
    }
}
