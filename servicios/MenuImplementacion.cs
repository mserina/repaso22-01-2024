using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso22_01_2024.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        //INTERFAZ Menu Principal
        public int mostrarMenuPrinicpal()
        {
            int opcionRespuesta;

            Console.WriteLine("===============");
            Console.WriteLine("  Acceso como: ");
            Console.WriteLine("---------------");
            Console.WriteLine("0. CerrarMenu");
            Console.WriteLine("1. Cliente");
            Console.WriteLine("2. Empleado");
            Console.WriteLine("===============");

            opcionRespuesta = Console.ReadKey(true).KeyChar-('0');
            return opcionRespuesta;
        }

        //INTERFAZ MENU CLIENTE
        public int mostrarMenuCliente()
        {
            int opcionRespuesta;

            Console.WriteLine("=================");
            Console.WriteLine("     CLIENTE      ");
            Console.WriteLine("=================");
            Console.WriteLine("Elige una opcion: ");
            Console.WriteLine("---------------");
            Console.WriteLine("0. Registro cliente");
            Console.WriteLine("1. Acceso cliente");
            Console.WriteLine("===============");

            opcionRespuesta = Console.ReadKey(true).KeyChar - ('0');
            return opcionRespuesta;
        }

        //LOGICA DEL MENU CLIENTE
        public void logicaMenuCliente()
        {
            ClientesInterfaz clienteCopia = new ClientesImplementacion();
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                int opcionSeleccionada = mostrarMenuCliente();

                switch (opcionSeleccionada)
                {
                    case 0:
                        
                        break;
                    case 1:

                        break;
                }
            }
        }



        //INTERFAZ DEL MENU ENMPLEADO
        public int mostrarMenuEmpleado()
        {
            int opcionRespuesta;

            Console.WriteLine("=================");
            Console.WriteLine("     EMPLEADO      ");
            Console.WriteLine("=================");
            Console.WriteLine("Elige una opcion: ");
            Console.WriteLine("---------------");
            Console.WriteLine("0. Validar cliente");
            Console.WriteLine("1. Mostrar cliente");
            Console.WriteLine("2. Borrar cliente");
            Console.WriteLine("=================");

            opcionRespuesta = Console.ReadKey(true).KeyChar-('0');
            return opcionRespuesta;
        }


        


        //LOGICA DEL MENU EMPLEADO
        public void logicaMenuEmpleado()
        {
            bool cerrarMenu = false;
            while (!cerrarMenu)
            {
                int opcionSeleccionada = mostrarMenuEmpleado();

                switch (opcionSeleccionada)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:

                        break;
                }
            }
        }
    }
}
