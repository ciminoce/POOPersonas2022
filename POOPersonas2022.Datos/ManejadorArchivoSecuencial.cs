using System;
using System.Collections.Generic;
using System.IO;
using POOPersonas2022.Entidades;

namespace POOPersonas2022.Datos
{
    public static class ManejadorArchivoSecuencial
    {
        private static string archivo = "Personas.txt";
        public static void GuardarEnArchivo(List<Persona> lista)
        {
            using (var escritor=new StreamWriter(archivo))
            {
                foreach (var persona in lista)
                {
                    string linea = ConstruirLinea(persona);
                    escritor.WriteLine(linea);
                }
            }

        }

        private static string ConstruirLinea(Persona persona)
        {
            return $"{persona.Dni}|{persona.Apellido}|{persona.PrimerNombre}|{persona.SegundoNombre}|{persona.Sexo.GetHashCode()}|{persona.FechaNacimiento.ToShortDateString()}|{(int)persona.Localidad}";
        }

        public static List<Persona> LeerArchivo()
        {
            List<Persona> lista = new List<Persona>();
            if (File.Exists(archivo))
            {
                using (var lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        Persona persona = ConstruirPersona(linea);
                        lista.Add(persona);
                    }
                }

            }
            return lista;
        }

        private static Persona ConstruirPersona(string linea)
        {
            var campos = linea.Split('|');
            Persona persona = new Persona()
            {
                Dni = long.Parse(campos[0]),
                Apellido = campos[1],
                PrimerNombre = campos[2],
                SegundoNombre = campos[3],
                Sexo =(Sexo) int.Parse(campos[4]),
                FechaNacimiento = DateTime.Parse(campos[5]),
                Localidad = (Localidad)int.Parse(campos[6])
            };
            return persona;
        }
    }
}
