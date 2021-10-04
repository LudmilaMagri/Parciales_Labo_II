using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CargarDatos
    {
        /// <summary>
        /// Carga listas de administradores
        /// </summary>
        public static void CargarUsuariosAdmin()
        {
            Shop.usuarioAdmin.Add(1234, "lud");
            Shop.usuarioAdmin.Add(111, "juan");
            Shop.usuarioAdmin.Add(1010, "lucas");
            Shop.usuarioAdmin.Add(2020, "lucia");
        }
        /// <summary>
        /// Carga listas de empleados
        /// </summary>
        public static void CargarUsuariosEmpleado()
        {
            Shop.usuarioEmpleado.Add(12, "pepa");
            Shop.usuarioEmpleado.Add(123, "luz");
            Shop.usuarioEmpleado.Add(222, "maria");
        }
        /// <summary>
        /// Carga la lista de contraseñas de administradores
        /// </summary>
        public static void CargarContraseñasAdmin()
        {
            Shop.listaContraseñasAdmin.Add(1234);
            Shop.listaContraseñasAdmin.Add(111);
            Shop.listaContraseñasAdmin.Add(1010);
            Shop.listaContraseñasAdmin.Add(2020);
         
        }
        /// <summary>
        /// Carga la lista de  contraseñas de empleados
        /// </summary>
        public static void CargarContraseñasEmpleado()
        {
            Shop.listaContraseñasEmpleado.Add(12);
            Shop.listaContraseñasEmpleado.Add(123);
            Shop.listaContraseñasEmpleado.Add(222);
        }

        /// <summary>
        /// Carga la lista de clientes
        /// </summary>
        public static void CargarClientes()
        {
            Shop.listaClientes.Add(new Cliente("Lopez", "Monica", 23404595, "calle 123", 3000));
            Shop.listaClientes.Add(new Cliente("Gutierrez", "Sol", 23222595, "bolivar 12", 2500));
            Shop.listaClientes.Add(new Cliente("Parker", "Peter", 34404595, "tacuari 63", 1000));
        }
        /// <summary>
        /// Carga la lista de empleados
        /// </summary>
        public static void CargarEmpleados()
        {
            Shop.listaEmpleado.Add(new Empleado("Potter", "Harry", 38585233, 30000));
            Shop.listaEmpleado.Add(new Empleado("Watson", "Emi", 36587733, 60000));
        }
        /// <summary>
        /// Carga la lista de administradores
        /// </summary>
        public static void CargarAdministrador()
        {
            Shop.listaAdmin.Add(new Administrador("Acosta", "Ivan", 32000444));
            Shop.listaAdmin.Add(new Administrador("Diaz", "Federico", 38888444));
            Shop.listaAdmin.Add(new Administrador("Silva", "Nuria", 32034334));
            Shop.listaAdmin.Add(new Administrador("Casan", "Moria", 235500444));
        }
        /// <summary>
        /// Carga la lista de productos
        /// </summary>
        public static void CargarProductos()
        {
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Alimentos, "Royal Canin", 3000, 20));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Alimentos, "Pedigree", 2000, 10));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Alimentos, "Whiskas", 4000, 15));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Camas, "Confort", 100, 10));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Camas, "Suave", 500, 10));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Camas, "Suave 2.0", 700, 20));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Farmacia, "Pipeta", 300, 30));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Farmacia, "Antipulguita", 200, 20));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Farmacia, "Vacuna", 150, 30));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Juguetes, "Pelota", 100, 50));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Juguetes, "Raton", 150, 35));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Juguetes, "Soga", 200, 60));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Limpieza, "Shampoo Espumita", 250, 50));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Limpieza, "Perfume", 400, 70));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Limpieza, "Jabon", 100, 60));

            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Alimentos, "Croquetas", 100, 0));
            Shop.listaProductos.Add(new Producto(Producto.ECategoria.Alimentos, "Golomiau", 100, 0));
        }

        /// <summary>
        /// Carga la lista de ventas
        /// </summary>
        public static void CargarVentas()
        {
            Shop.listaTotalCompras.Add(new Compra(300, 0, 23404595));
            Shop.listaTotalCompras.Add(new Compra(500, 1, 23222595));
            Shop.listaTotalCompras.Add(new Compra(700, 0, 23404595));
            Shop.listaTotalCompras.Add(new Compra(200, 2, 34404595));
        }

      
        
        
    }
}
