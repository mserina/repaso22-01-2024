using repaso22_01_2024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos del servicio Cliente
    /// msm - 220124
    /// </summary>
    internal interface ClientesInterfaz
    {
        /// <summary>
        /// Metodo para registrar clientes
        /// msm - 220124
        /// </summary>
        public void registroClientes(List <ClienteDto> listaClientes);
    }
}
