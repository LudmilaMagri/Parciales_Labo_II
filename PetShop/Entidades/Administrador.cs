using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Persona
    {
        private int idAdministrador;
        public Administrador(string apellido, string nombre, int dni) : base(apellido, nombre, dni)
        {
            this.idAdministrador = id++;
        }
        public Administrador()
        {

        }
        public int Id
        {
            get { return this.idAdministrador; }
        }
        public static void AltaAdmin(Administrador admin)
        {
             Shop.listaAdmin.Add(admin);
        }
        public static void BajaAdmin(int idAux)
        {
            foreach (Administrador item in Shop.listaAdmin)
            {
                if (item.idAdministrador == idAux)
                {
                    Shop.listaAdmin.Remove(item);
                    break;
                }
            }
        }
        public override void Eliminar(int id)
        {
            foreach (Administrador item in Shop.listaAdmin)
            {
                if (item.idAdministrador == id)
                {
                    Shop.listaAdmin.Remove(item);
                    break;
                }
            }
        }
    }
}
