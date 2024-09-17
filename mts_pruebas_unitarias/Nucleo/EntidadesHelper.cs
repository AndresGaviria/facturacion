using lib_entidades;

namespace mst_pruebas_unitarias.Nucleo
{
    public class EntidadesHelper
    {
        public static Personas ObtenerPersonas()
        {
            return new Personas()
            {
                Cedula = "627",
                Nombre = "Jose Jose",
                Fecha = new DateTime(1989, 08, 12),
                Activo = true,
            };
        }
    }
}