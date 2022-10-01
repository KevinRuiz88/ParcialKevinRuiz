using System.Collections.Generic;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioEstudiante
    {
        private List<Estudiante> estudiantes;
        private Archivo archivo;

        public ServicioEstudiante()
        {
            estudiantes = new List<Estudiante>();
            archivo = new Archivo("Registro-Academico.dat");
            CargarDatos();
        }

        public List<Estudiante> Listar()
        {
            return estudiantes;
        }

        private void CargarDatos()
        {
            estudiantes = archivo.CargarContactos();
        }


    }
}