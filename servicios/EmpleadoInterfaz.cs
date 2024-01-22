using repaso22_01_2024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos del servicio Empleado
    /// msm - 220124
    /// </summary>
    internal interface EmpleadoInterfaz
    {
        /// <summary>
        /// Metodo que muestra los clientes validados
        /// msm - 220124
        /// </summary>
        public void mostrarClientes(List<ClienteDto> listaClientes);
    }
}
