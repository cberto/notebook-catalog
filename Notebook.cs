using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    class Notebook

    {
        private static List<Notebook> notebooks;

        private string modelo;
        private string descipcion;
        private Marca tipoMarca;
        private double precio;

        [DisplayName("Modelo")]


        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }
        [DisplayName("Descripcion")]

        public string Descripcion
        {
            get
            {
                return descipcion;
            }

            set
            {
                descipcion = value;
            }
        }
       
        [DisplayName("Precio")]
        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
        [DisplayName("Tipo Marca")]
        public Marca TipoMarca
        {
            get
            {
                return tipoMarca;
            }

            set
            {
                tipoMarca = value;
            }
        }

        public static List<Notebook> Notebooks
        {
            get
            {
                return notebooks;
            }

            set
            {
               notebooks = value;
            }
        }

        public Notebook()
        {
            modelo = "";
            descipcion = "";
            tipoMarca = null;
            
            precio = 0;
        }

        public Notebook(string modelo, string descipcion, Marca tipoMarca, double precio)
        {
            this.modelo = modelo;
            this.descipcion = descipcion;
            this.tipoMarca = tipoMarca;
            
            this.precio = precio;

        }

       
        public override string ToString() 
        {
            return modelo + " - " + descipcion + ("+precio+");


        }
        public void Guardar()
        {
            if (Notebook.notebooks == null)
                Notebook.Notebooks = new List<Notebook>();

            Notebook.Notebooks.Add(this);
        }
        public void Eliminar()
        {
            Notebooks.Remove(this);
        }

        public static List<Notebook> Buscar(string buscado)
        {
            buscado = buscado.Trim().ToLower();

            if (buscado == "")
                return Notebook.Notebooks;

            List<Notebook> encontrados = new List<Notebook>();
            foreach (Notebook n in Notebook.Notebooks)
            {
                if (n.modelo.Trim().ToLower().Contains(buscado) ||
                    n.descipcion.Trim().ToLower().Contains(buscado) ||
                    n.precio.ToString().Contains(buscado) ||
                    n.tipoMarca.Nombre.Trim().ToLower().Contains(buscado) ||
                    n.tipoMarca.Alias.Trim().ToLower().Contains(buscado) ||
                    n.tipoMarca.Codigo.ToString().ToLower().Contains(buscado)

                    )
                {
                    encontrados.Add(n);
                }
            }
            return encontrados;
        }
    }
}
