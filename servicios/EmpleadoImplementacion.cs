using repaso22_01_2024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    /// <summary>
    /// Implementacion que contiene la logica de los metodos del servicio de Empleado
    /// msm - 220124
    /// </summary>
    internal class EmpleadoImplementacion
    {
        public void mostrarClientes(List<ClienteDto> listaClientes)
        {
            foreach (var item in listaClientes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
