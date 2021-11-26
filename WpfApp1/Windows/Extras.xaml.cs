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
using VegaWPF.LogicaNegocio;
using System.Windows.Shapes;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Lógica de interacción para Extras.xaml
    /// </summary>
    public partial class Extras : Window
    {


        //GENERO EL ARRAYLIST
        public static System.Collections.ArrayList Array = new System.Collections.ArrayList();
        
        //CREO UN OBKJETO LIBRO PARA EL BINDING
        Lista lista = new Lista();

        //CREO UN LIBRO Y SU CLON
        Libro Milibro = new Libro();
        Libro CloneLibro;

        public Extras()
        {
            InitializeComponent();
            Milibro.Titulo = "Vega";

            //DATAGRID CONTEXT
            DataGridPrueba.DataContext = lista;

            //LENO EL ARRAY
            Array.Add("Posicion1");
            Array.Add("Posicion2");
            Array.Add("Posicion3");
        }

          private void Pulsar_Click(object sender, RoutedEventArgs e)
        {

            CloneLibro = (Libro)Milibro.Clone();
            if(!txtTitulo.Text.Equals(""))
            {
                CloneLibro.Titulo = txtTitulo.Text;
            }

            MessageBox.Show("Este es el titulo original: " + Milibro.Titulo + "\n"
                          + "Este es el titulo del clon: " + CloneLibro.Titulo );


        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Int32.Parse(ArrayText.Text) >= 0 && Int32.Parse(ArrayText.Text) < 3)
            {
                textPos.Text = (string)Array[Int32.Parse(ArrayText.Text)];
            }
            else
            {
                textPos.Text = "Introduce un numero valido";
            }
        }
    }
}

