using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra 
    {
        private double costoFinal;
        private int idCliente;
        private int dniCliente;
        List<Producto> listaProductos;

        #region Constructores
        public Compra()
        {
            this.listaProductos = new List<Producto>();
        }
        public Compra(double costoFinal)
        {
            this.costoFinal = costoFinal;
        }

        public Compra(double costoFinal, int idCliente, int dniCliente)
        {
            this.costoFinal = costoFinal;
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
        }

        #endregion

        #region Propiedades
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public int DniCliente
        {
            get { return dniCliente; }
            set { dniCliente = value; }
        }

        public double CostoFinal
        {
            get { return costoFinal; }
            set { costoFinal = value; }
        }
        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
        }
        #endregion

        /// <summary>
        /// Agrega un producto a la lista de productos
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarProductoLista(Producto producto)
        {
            this.listaProductos.Add(producto);
        }

       /// <summary>
       /// Calcula el costo final de la compra
       /// </summary>
       /// <returns></returns>
        public double CalcularCostoFinal()
        {
            foreach (Producto item in listaProductos)
            {
                this.costoFinal = this.costoFinal +item.Precio;
            }
            return costoFinal;
        }
        

        static public bool operator +(List<Compra> listaCompras, Compra compra)
        {
            if(compra is Compra)
            {
                listaCompras.Add(compra);
                return true;
            }
            return false;
        }
      
    }
}
