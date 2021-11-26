using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VegaWPF.LogicaNegocio
{
    class Usuario : IDataErrorInfo
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }



        public Usuario(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
        }

        public Usuario()
        {
        }


        //DATAERRORINFO

        public string Error => throw new NotImplementedException();


        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                        result = "Debe introducir el usuario";
                }

                if (columnName == "Correo")
                {
                    if (string.IsNullOrEmpty(Correo))
                        result = "Debe introducir el usuario";
                }

                return result;
            }
        }

    }
}
