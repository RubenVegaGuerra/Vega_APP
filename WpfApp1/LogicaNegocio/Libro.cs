using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace VegaWPF.LogicaNegocio
{

    
    class Libro : INotifyPropertyChanged, ICloneable
    {

        //PROPERTYCHANGED
        public event PropertyChangedEventHandler PropertyChanged;

        //CAMBIAR PROPIEDAD POR SI SE MODIFICA
        public String titulo;
        public String Titulo {
            get { return titulo;  }
            set 
            {
                this.titulo = value;
                if (PropertyChanged != null)       
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Titulo")); 
            }
        }

        //CONSTRUCTOR
        public Libro(string titulo)
        {
            
            this.titulo = titulo;
        }

        public Libro()
        {           
        }


        //DATAERRORINFO
        public string this[string columnName]
        {
            get
            {
                string result = "";
                if(columnName == "Titulo")
                {
                    if (string.IsNullOrEmpty(Titulo))
                        result = "Debe introducir el titulo";
                }

                return result;
            }
        }



        


        //CLONE
        public object Clone()
        {
            return this.MemberwiseClone(); 
        }

        public static implicit operator string(Libro v)
        {
            throw new NotImplementedException();
        }
    }
}
