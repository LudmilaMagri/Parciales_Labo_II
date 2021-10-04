using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int dni;
        public static int id;

        #region Constructores
        protected Persona(string apellido, string nombre, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }
        protected Persona()
        {

        }
        static Persona()
        {
            id = 0;
        }
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return apellido; }
            set 
            { 
                if(apellido!= null && Validaciones.SoloLetras(apellido))
                apellido = value; 
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set 
            { 
                if(nombre != null && Validaciones.SoloLetras(nombre))
                nombre = value; 
            }
        }
        public int Dni
        {
            get { return dni; }
            set 
            {
                if(Validaciones.EsDni(dni.ToString()) && Validaciones.EsNumericaInt(dni.ToString()))
                dni = value; 
            }
        }
        #endregion

        public abstract void Eliminar(int id);
        
        /// <summary>
        /// Muestra el nombre, apellido, dni.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Nombre: {this.nombre}");
            s.AppendLine($"Apellido: {this.apellido}");
            s.AppendLine($"DNI: {this.dni}");
            return s.ToString();
        }
    }
}
