using System;
using System.Collections.Generic;
using System.Text;

namespace VegaWPF.LogicaNegocio
{
    class Sneaker
    {
            
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public String Precio { get; set; }
        public Sneaker()
        {
        }

        public Sneaker(string marca, string modelo, String precio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " " + Precio;
        }
     

    }
}
