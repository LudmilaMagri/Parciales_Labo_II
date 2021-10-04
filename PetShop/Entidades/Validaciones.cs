using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validaciones
    {

        /// <summary>
        /// Verifica si la cadena tiene letras
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool SoloLetras(string cadena)
        {
            int contador = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                if(char.IsLetter(cadena[i]))
                {
                    contador++;
                }
            }
            if (contador == cadena.Length)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena sean numeros float
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool EsNumerica(string cadena)
        {
           if(float.TryParse(cadena, out float cadenaParse))
           {
                return true;
           }
            return false;
        }
        /// <summary>
        /// Verifica que la cadena sean numeros int
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool EsNumericaInt(string cadena)
        {
            if (int.TryParse(cadena, out int cadenaParse))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Verifica si tiene la cantidad de digitos de un dni
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static bool EsDni(string cadena)
        {
            if((cadena.Length>=7 && cadena.Length<= 8) && int.TryParse(cadena, out int dniParse))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida si hay stock del producto pasado por parametro
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool HayStock(Producto producto)
        {
            if(producto.Stock != 0 )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si el cliente tiene saldo suficiente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool SaldoSuficiente(Cliente cliente)
        {
            if(cliente.Saldo != 0)
            {
                return true;
            }
            return false;
        }

       
    }
}
