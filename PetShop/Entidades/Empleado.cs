using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Persona
    {
        private int idEmpleado;
        private double sueldo;

        #region Constructores
        public Empleado(string apellido, string nombre, int dni, double sueldo) : base(apellido, nombre, dni)
        {
            this.idEmpleado = id++;
            this.sueldo = sueldo;
        }
        public Empleado()
        {

        }
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.idEmpleado; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }
        #endregion

        /// <summary>
        /// Agrega un empleado a la lista de empleados
        /// </summary>
        /// <param name="empleado"></param>
        public static void AltaEmpleado(Empleado empleado)
        {
            Shop.listaEmpleado.Add(empleado);
        }

        /// <summary>
        /// Busca el id del empleado a eliminar y lo elimina de la lista de empleados.
        /// </summary>
        /// <param name="id"></param>
        public override void Eliminar(int id)
        {
            foreach (Empleado item in Shop.listaEmpleado)
            {
                if (item.idEmpleado == id)
                {
                    Shop.listaEmpleado.Remove(item);
                    break;
                }
            }
        }

    }
}
