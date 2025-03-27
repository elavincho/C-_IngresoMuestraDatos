using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresantesIFTS29
{
    internal class Ingresantes
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string documento;

        //Constructor Vacio
        public Ingresantes()
        {

        }

        //Constructor con parametros
        public Ingresantes(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }

        // Geters
        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }
        public string getDocumento()
        {
            return documento;
        }

        //Seters
        public void setNombre(string nombre)
        {
            this.nombre= nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido= apellido;
        }

        public  void setDocumento(string documento)
        {
            this.documento= documento;
        }
    }
}
