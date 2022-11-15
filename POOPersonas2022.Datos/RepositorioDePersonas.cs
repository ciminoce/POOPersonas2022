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

        public bool ExistePersona(long dniBuscado)
        {
            return listaPersonas.Any(p => p.Dni == dniBuscado);
        }

        public List<Persona> FiltrarPorSexo(Sexo sexo)
        {
            return listaPersonas.Where(p => p.Sexo == sexo).ToList();
        }

        public List<Persona> FiltrarPorLocalidad(Localidad localidadFiltrar)
        {
            return listaPersonas.Where(p => p.Localidad == localidadFiltrar).ToList();
        }

        public List<Persona> OrdenarAlfaAsc()
        {
            return listaPersonas
                .OrderBy(p => p.Apellido)
                .ThenBy(p => p.PrimerNombre)
                .ThenBy(p => p.SegundoNombre)
                .ToList();
        }

        public List<Persona> OrdenarAlfaDesc()
        {
            return listaPersonas.OrderByDescending(p => p.Apellido)
                .ThenByDescending(p => p.PrimerNombre)
                .ThenByDescending(p => p.SegundoNombre)
                .ToList();
        }

        public List<Persona> OrdenarPorEdadAsc()
        {
            return listaPersonas.OrderBy(p => p.GetEdad()).ToList();
        }

        public List<Persona> GetLista(string comienzaCon)
        {
            return listaPersonas.Where(p => p.PrimerNombre.StartsWith(comienzaCon))
                .ToList();
        }
    }
}
