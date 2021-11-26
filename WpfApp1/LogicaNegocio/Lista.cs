using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VegaWPF.LogicaNegocio
{
    class Lista
    {

        public static ObservableCollection<Libro> listaLibro { get; set; }


        public Lista()
        {
            listaLibro = new ObservableCollection<Libro>();
            listaLibro.Add(new Libro("Titulo1"));
            listaLibro.Add(new Libro("Titulo2"));
            listaLibro.Add(new Libro("Titulo3"));
        }
    }
}
