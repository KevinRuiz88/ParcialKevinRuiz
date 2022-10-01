using Logica;

namespace Presentacion
{
    public abstract class PresentarEstudiante
    {
        protected ServicioEstudiante servicio = new ServicioEstudiante();

        public abstract void Lista();
    }
}