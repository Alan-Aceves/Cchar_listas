using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cchar_listas
{
    class Articulo
    {
        /* Atributos */
        private string nombre;
        private int id;

        /* CONSTRUCTOR  */ 
        public Articulo()
        {
            id = 0;
            nombre = String.Empty;
        }
        public Articulo (string articulo, int numero_id )
        {
            id = numero_id;
            nombre = articulo;
        }

        /* METODOS */
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /* DESTRUCTOR */
        ~Articulo(){}
    }

}
