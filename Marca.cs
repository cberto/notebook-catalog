using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    class Marca
    {
        private static List<Marca> marcas;
        private string nombre;
        private int codigo;
        private string alias;

        [DisplayName("Nombre de la Marca")]
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }
        [DisplayName("Codigo de la Marca")]
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }
        [DisplayName("Aleas de la marca")]
        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }
        
             public static List<Marca> Marcas
        {
            get
            {
                return marcas;
            }

            set
            {
                marcas = value;
            }
        }

        public Marca ()
        {
            nombre = "";
            codigo = 0;
            alias = "";


         }

        public Marca(string nombre, int codigo, string aleas)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.alias = aleas;
            

        }

        public override string ToString()
        {
            return nombre+" - "+alias+" ("+codigo+")";
        }

        public void Guardar()
        {
            if (Marca.marcas == null)
                Marca.marcas = new List<Marca>();

            Marca.marcas.Add(this);
        }
        public void Eliminar()
        {
            Marcas.Remove(this);
        }
    }
}

