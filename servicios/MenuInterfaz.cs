using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    internal interface MenuInterfaz
    {
        public int mostrarMenuPrinicpal();

        public int mostrarMenuCliente();

        public int mostrarMenuEmpleado();

        public void logicaMenuCliente();
    }
}
