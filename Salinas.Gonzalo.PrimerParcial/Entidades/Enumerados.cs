using System;

namespace Enumerados
{
    /// <summary>
    /// Enumerado de Tipo Llamada, dependiendo el numero del telefono
    /// </summary>
        public enum TipoLlamada { Local,LargaDistancia,Internacional,SinAsignar}
    /// <summary>
    /// Enumerado de Tipo Telefono, dependiendo el telefono
    /// </summary>
        public enum TipoTelefono { ADisco,Teclado,SinAsignar}
    /// <summary>
    /// Enumerado de Estado Cliente, estado en el que se encuentra el cliente
    /// </summary>
        public enum EstadoCliente { Asignado,Esperando,Atendido}
    /// <summary>
    /// Enumerado de Estado Puesto, estado en el que se encuentra el puesto
    /// </summary>
        public enum EstadoPuesto { EnUso,SinUso}


}
