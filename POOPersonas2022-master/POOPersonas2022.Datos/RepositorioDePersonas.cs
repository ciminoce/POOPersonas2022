using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOPersonas2022.Entidades;

namespace POOPersonas2022.Datos
{
    public class RepositorioDePersonas
    {
        private List<Persona> listaPersonas;
        private bool hayCambios = false;
        public RepositorioDePersonas()
        {
            listaPersonas = new List<Persona>();
            listaPersonas=ManejadorArchivoSecuencial.LeerArchivo();
        }

        public void Agregar(Persona persona)
        {
            hayCambios = true;
            listaPersonas.Add(persona);
        }

        public void Borrar(Persona persona)
        {
            hayCambios = true;
            listaPersonas.Remove(persona);
        }

        public void Editar(Persona persona)
        {
            hayCambios = true;
        }
        public int GetCantidad()
        {
            return listaPersonas.Count;
        }

        public void Guardar()
        {
            if (hayCambios)
            {
                ManejadorArchivoSecuencial.GuardarEnArchivo(listaPersonas);
            }
        }

        public List<Persona> GetLista()
        {
            return listaPersonas;
        }
    }
}
