using repaso22_01_2024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    internal class ClientesImplementacion : ClientesInterfaz
    {
        public void registroClientes(List<ClienteDto> listaClientes)
        {
            ClienteDto clienteNuevo = nuevoCliente();
            listaClientes.Add(clienteNuevo);
        }

        private ClienteDto nuevoCliente()
        {
            string nombreCompleto;
            string DNI;
            string email;
            string contraseña;

            Console.WriteLine("Inserte DNI");
            DNI = Console.ReadLine();
            Console.WriteLine("Inserte el Nombre Completo, ponga espacios entre cada nombre y apellido");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("Inserte email");
            email = Console.ReadLine();
            Console.WriteLine("Inserte contraseña");
            contraseña = Console.ReadLine();

            ClienteDto cliente = new ClienteDto(DNI, nombreCompleto, email, contraseña);
            return nuevoCliente();
        }

    }
}
