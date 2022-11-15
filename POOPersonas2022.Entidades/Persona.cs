using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPersonas2022.Entidades
{
    public class Persona
    {
        public long Dni { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Sexo Sexo { get; set; }
        public Localidad Localidad { get; set; }

        public int GetEdad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.AddYears(edad)>DateTime.Today)
            {
                edad--;
            }
            return edad;
        }

        public string NombreCompleto()
        {
            return $"{Apellido}, {PrimerNombre} {SegundoNombre}";
        }
    }
}
