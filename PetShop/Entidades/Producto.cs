using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public enum ECategoria
        {
            Alimentos, Juguetes, Camas, Limpieza, Farmacia
        };

        private string nombre;
        private double precio;
        private int stock;
        private int codigo;
        private ECategoria tipo;

        #region Constructores
        public Producto(ECategoria tipo, string nombre, double precio, int stock)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.codigo = Shop.codigoProducto++;
        }
        public Producto()
        {

        }
        #endregion

        #region Propiedades
        public ECategoria Tipo
        {
            get { return tipo; }
        }
        public int Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set 
            { 
                if(Validaciones.EsNumerica(precio.ToString()))
                precio = value; 
            }
        }

        public int Stock
        {
            get { return stock; }
            set 
            {
                if (Validaciones.EsNumericaInt(precio.ToString()))
                    stock = value; 
            }
        }
        #endregion

        /// <summary>
        /// Agrega un producto a la lista de productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        static public bool AgregarProducto(Producto producto)
        {
            if (Shop.listaProductos + producto)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Busca el codigo del producto en la lista de productos y lo elimina
        /// </summary>
        /// <param name="codigo"></param>
        public static void BajaProducto(int codigo)
        {
            foreach (Producto item in Shop.listaProductos)
            {
                if (item.codigo == codigo)
                {
                    Shop.listaProductos.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// Resta el stock del producto pasado por parametro
        /// </summary>
        /// <param name="producto"></param>
        public static void RestarStock(Producto producto)
        {
            foreach (Producto item in Shop.listaProductos)
            {
                if (item.codigo == producto.codigo)
                {
                    item.stock = item.stock - 1;
                }
            }
        }

        /// <summary>
        /// Sobrecarga de operador +. Suma un producto a la lista de productos
        /// </summary>
        /// <param name="listaProducto"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        static public bool operator +(List<Producto> listaProducto, Producto producto)
        {
            if (producto is Producto)
            {
                listaProducto.Add(producto);
                return true;
            }
            return false;
        }

        public static implicit operator int(Producto producto)
        {
            return (int)producto.precio;
        }
    }

}
