using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int idCliente;
        private string direccion;
        private double saldo;
        List<Compra> comprasPorCliente;

        #region Constructores
        public Cliente(string apellido, string nombre, int dni, string direccion, double saldo) : base(apellido, nombre, dni)
        {
            this.idCliente = id++;
            this.direccion = direccion;
            this.saldo = saldo;
            this.comprasPorCliente = new List<Compra>();
        }

        public Cliente()
        {
            this.comprasPorCliente = new List<Compra>();
        }
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.idCliente; }
        }
        public string Direccion
        {
            set { this.direccion = value; }
            get { return this.direccion; }
        }
        public double Saldo
        {
            set { this.saldo = value; }
            get { return this.saldo; }
        }
        #endregion

        /// <summary>
        /// Agrega un cliente a la lista de clientes
        /// </summary>
        /// <param name="cliente"></param>
        public static void AltaCliente(Cliente cliente)
        {
            Shop.listaClientes.Add(cliente);
        }
        /// <summary>
        /// Agrega una compra a la lista de compras por clientes
        /// </summary>
        /// <param name="compra"></param>
        public void AgregarCompraLista (Compra compra)
        {
            this.comprasPorCliente.Add(compra);
        }
       
        /// <summary>
        /// Al saldo del cliente le resta el costo final de la compra
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="compra"></param>
        public void RestarSaldo(Cliente cliente, Compra compra)
        {
            foreach (Cliente item in Shop.listaClientes)
            {
                if(cliente.Id == item.Id)
                {
                    item.saldo = item.saldo - compra.CostoFinal;
                }
            }
        }
        /// <summary>
        /// Busca el id del cliente y lo borra de la lista de clientes.
        /// </summary>
        /// <param name="id"> id a buscar</param>
        public override void Eliminar(int id)
        {
            foreach (Cliente item in Shop.listaClientes)
            {
                if (item.idCliente == id)
                {
                    Shop.listaClientes.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// Muestra el nombre, apellido, dni y direccion del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString ()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine($"Nombre: {this.Nombre }");
            s.AppendLine($"Apellido: {this.Apellido }");
            s.AppendLine($"Dni: {this.Dni }");
            s.AppendLine($"Direccion: {this.direccion }");
            return s.ToString();
        }

    }
}
