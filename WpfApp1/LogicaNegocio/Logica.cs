using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace VegaWPF.LogicaNegocio
{
    class Logica
    {



        //-----------METODOS DEL WINDOW 2-----------

        public static void PonerMarcas(ComboBox ComboBoxMarca)
        {
            //COMBOBOX MARCAS
            List<String> listaMarcas = new List<String>();
            listaMarcas.Add("Nike");
            listaMarcas.Add("Jordan");
            listaMarcas.Add("Adidas");
            foreach (String s in listaMarcas)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = s;
                ComboBoxMarca.Items.Add(cbi);
            }

        }

    //DEPENDIENDO DE LA MARCA SACA UNOS MODELOS U OTROS
    public static void Comprobar(String lblMarca, ComboBox ComboBoxModelo )
        {

            switch (lblMarca)
            {
                case "Nike":

                    //COMOBOBOX MODELOS NIKE
                    List<String> listaModelosNike = new List<String>();
                    listaModelosNike.Clear();
                    listaModelosNike.Add("AirMax 1");
                    listaModelosNike.Add("AirMax 95");
                    listaModelosNike.Add("Air Max 97");
                    listaModelosNike.Add("Huarache");
                    listaModelosNike.Add("Air Force");

                    ComboBoxModelo.Items.Clear();
                    foreach (String s in listaModelosNike)
                    {
                        ComboBoxItem cbi2 = new ComboBoxItem();
                        cbi2.Content = s;
                        ComboBoxModelo.Items.Add(cbi2);
                    }
                    break;

                case "Jordan":

                    //COMOBOBOX MODELOS JORDAN
                    List<String> listaModelosJordan = new List<String>();
                    listaModelosJordan.Clear();
                    listaModelosJordan.Add("1");
                    listaModelosJordan.Add("2");
                    listaModelosJordan.Add("3");
                    listaModelosJordan.Add("4");
                    listaModelosJordan.Add("5");

                    ComboBoxModelo.Items.Clear();
                    foreach (String s in listaModelosJordan)
                    {
                        ComboBoxItem cbi2 = new ComboBoxItem();
                        cbi2.Content = s;
                        ComboBoxModelo.Items.Add(cbi2);
                    }
                    break;


                case "Adidas":

                    //COMOBOBOX MODELOS ADIDAS
                    List<String> listaModelosAdidas = new List<String>();
                    listaModelosAdidas.Clear();
                    listaModelosAdidas.Add("SuperStar");
                    listaModelosAdidas.Add("Stan Smith");
                    listaModelosAdidas.Add("Samba");
                    listaModelosAdidas.Add("Continental");

                    ComboBoxModelo.Items.Clear();
                    foreach (String s in listaModelosAdidas)
                    {
                        ComboBoxItem cbi2 = new ComboBoxItem();
                        cbi2.Content = s;
                        ComboBoxModelo.Items.Add(cbi2);
                    }
                    break;

            }
        }

        
        //ASOCIA IMAGENES SEGUN LA MARCA SELECCIONADA
        public static void ImagenMarca(Label lblMarca, Image lblImage)
        {

            switch (lblMarca.Content)
            {
                case "Nike":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Nike.png", UriKind.Relative));
                    break;

                case "Jordan":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Jordan.png", UriKind.Relative));
                    break;

                case "Adidas":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Adidas.png", UriKind.Relative));
                    break;

            }
        }


        //ASOCIA IMAGENES SEGUN LA MARCA SELCCIONADA
        public static void ImagenModelo(Label lblModelo, Image lblImage)
        {

            switch (lblModelo.Content)
            {
                //NIKE
                case "AirMax 1":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\AirMax1.png", UriKind.Relative));
                    break;

                case "AirMax 95":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Air Max 95.png", UriKind.Relative));
                    break;

                case "Air Max 97":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Air Max 97.png", UriKind.Relative));
                    break;

                case "Huarache":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Huarache.png", UriKind.Relative));
                    break;

                case "Air Force":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Air Force.png", UriKind.Relative));
                    break;



                //JORDAN
                case "1":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\1.png", UriKind.Relative));
                    break;

                case "2":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\2.png", UriKind.Relative));
                    break;

                case "3":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\3.png", UriKind.Relative));
                    break;

                case "4":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\4.png", UriKind.Relative));
                    break;

                case "5":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\5.png", UriKind.Relative));
                    break;



                //ADIDAS
                case "SuperStar":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\AirMax1.png", UriKind.Relative));
                    break;

                case "Stan Smith":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Air Max 95.png", UriKind.Relative));
                    break;

                case "Samba":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Air Max 97.png", UriKind.Relative));
                    break;

                case "Continental":
                    lblImage.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(@"\Windows\Huarache.png", UriKind.Relative));
                    break;


            }
        }

        public static void Precio(Label lblModelo, Label lblPrecio)
        {

            switch (lblModelo.Content)
            {
                //NIKE
                case "AirMax 1":
                    lblPrecio.Content = "150€";
                    break;

                case "AirMax 95":
                    lblPrecio.Content = "120€";
                    break;

                case "Air Max 97":
                    lblPrecio.Content = "180€";
                    break;

                case "Huarache":
                    lblPrecio.Content = "90€";
                    break;

                case "Air Force":
                    lblPrecio.Content = "80€";
                    break;



                //JORDAN
                case "1":
                    lblPrecio.Content = "130€";
                    break;

                case "2":
                    lblPrecio.Content = "100€";
                    break;

                case "3":
                    lblPrecio.Content = "160€";
                    break;

                case "4":
                    lblPrecio.Content = "120€";
                    break;

                case "5":
                    lblPrecio.Content = "110€";
                    break;



                //ADIDAS
                case "SuperStar":
                    lblPrecio.Content = "80€";
                    break;

                case "Stan Smith":
                    lblPrecio.Content = "90€";
                    break;

                case "Samba":
                    lblPrecio.Content = "99€";
                    break;

                case "Continental":
                    lblPrecio.Content = "100€";
                    break;


            }
        }



        //-------------METODOS DEL REGISTER-----------

        public static void comprobarRegistro(PasswordBox TextContra, PasswordBox TextContra2, Window w)
        {
            Boolean bandera1 = true;
            Boolean bandera2 = true;

            //SI LAS DOS COSAS ESTAN MAL HAGO UN MENSAJE CONJUNTO DE LOS DOS ERROES
            if (TextContra.Password != TextContra2.Password && TextContra.Password.Length < 7)
            {
                MessageBox.Show("Las contraseñas tienen que ser las mismas y tener mas de 7 carácteres", "Fallo al registrar");
                bandera1 = false;
                bandera2 = false;
            }
            else
            //LAS CONTRASEÑAS NO SON IGUALES
            if (TextContra.Password != TextContra2.Password)
            {
                MessageBox.Show("Las contraseñas tienen que ser las mismas", "Fallo al registrar");
                bandera1 = false;
            }
            else
            //LA CONTRASEÑA TIENE QUE TENER 7 CARACTERES O MAS
            if (TextContra.Password.Length < 7)
            {
                MessageBox.Show("La contraseña tiene que tener mas de 7 carácteres", "Fallo al registrar");
                bandera2 = false;
            }

            //SI TODO ESTA BIEN REGISTRA AL USUARIO
            if (bandera1 && bandera2 == true)
            {
                w.Close();
            }


        }

    }


}
