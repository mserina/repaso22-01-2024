using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.Dtos
{
    /// <summary>
    /// Contiene los atributos y metodos de los cliente
    /// msm - 220122
    /// </summary>
    internal class ClienteDto
    {
        //CAMPOS
        int idCliente;
        string dniCliente;
        string nombreCliente;
        string apellido1Cliente;
        string apellido2Cliente;
        string nombreCompletoCliente;
        string emailCliente;
        string contraseniaCliente;
        bool esValidado;

        //GETTERS AND SETTERS
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }

        //CONTROLADDORES
        public ClienteDto()
        {
        }

        public ClienteDto( string dniCliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente)
        {
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
            this.nombreCliente = nombreCliente;
            this.apellido1Cliente = apellido1Cliente;
            this.apellido2Cliente = apellido2Cliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.esValidado = esValidado;
        }

        //TO STRING
        override
        public string ToString()
        {
            string clienteString =
                " DNI: " + this.dniCliente +
                " Nombre Completo: " + this.nombreCompletoCliente;
            
            return clienteString;
        }
    }
}
