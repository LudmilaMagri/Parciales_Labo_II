using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Shop
    {
        public static List<Cliente> listaClientes;
        public static List<Empleado> listaEmpleado;
        public static List<Administrador> listaAdmin;
        public static List<Producto> listaProductos;
        public static List<Compra> listaTotalCompras;
        public static Dictionary<int, string> usuarioAdmin;
        public static Dictionary<int, string> usuarioEmpleado;
        public static List<int> listaContraseñasAdmin; 
        public static List<int> listaContraseñasEmpleado; 

        public static int codigoProducto;

        static Shop()
        {
            listaClientes = new List<Cliente>();
            listaEmpleado = new List<Empleado>();
            listaAdmin = new List<Administrador>();
            listaProductos = new List<Producto>();
            usuarioAdmin = new Dictionary<int, string>();
            usuarioEmpleado = new Dictionary<int, string>();
            listaTotalCompras = new List<Compra>();
            listaContraseñasAdmin = new List<int>(usuarioAdmin.Keys);
            listaContraseñasEmpleado = new List<int>(usuarioEmpleado.Keys);
            codigoProducto = 0;
        }


        /// <summary>
        /// Calcula el costo final que tienen la lista de compras total
        /// </summary>
        /// <returns></returns>
        static public double Costofinal()
        {
            double precioAcumulado = 0;
            foreach (Compra item in listaTotalCompras)
            {
                precioAcumulado = item.CostoFinal + precioAcumulado;
            }
            return precioAcumulado;
        }
    }
}

