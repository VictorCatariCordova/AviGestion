using System;
using System.Collections.Generic;
using AviGestion_.Datos;

namespace AviGestion_.Logica
{
    public class BitacoraLogica
    {
        private static DatosBitacora datos = new DatosBitacora();

        // Llamalo así desde cualquier lado: BitacoraLogica.Registrar(usuarioActual.Nombre, "Alta", "Productos", "Código ABC-001");
        public static void Registrar(string usuario, string accion, string modulo, string detalle = "")
        {
            try
            {
                datos.Registrar(usuario, accion, modulo, detalle);
            }
            catch
            {
                // La bitácora no debe romper la operación principal si falla el registro.
                // (Si querés que sea estricto, sacá este try/catch.)
            }
        }

        public List<RegistroBitacora> Buscar(string usuario, string accion, string modulo,
            DateTime? fechaDesde, DateTime? fechaHasta)
        {
            return datos.Listar(usuario, accion, modulo, fechaDesde, fechaHasta);
        }
    }
}