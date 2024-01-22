using repaso22_01_2024.Dtos;
using repaso22_01_2024.servicios;

namespace repaso22_01_2024
{
    /// <summary>
    /// Clase principal del programa
    /// msm - 220224
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo que se encarga del flujo de la aplicacion
        /// msm - 220124
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          //Listas
          List<ClienteDto> listaClientes = new List<ClienteDto>();
            
          //Objetos
              MenuInterfaz mi = new MenuImplementacion();
              ClientesInterfaz clienteCopia = new ClientesImplementacion();
          //Variables
              bool cerrarMenu = false;
              int opcionSeleccionada;

          //MenuPrincipal
              while(!cerrarMenu)
              {
                opcionSeleccionada = mi.mostrarMenuPrinicpal();

                    switch(opcionSeleccionada)
                    {
                        case 0:
                            cerrarMenu = true;
                            break;
                        case 1:
                            mi.mostrarMenuCliente();
                            break;
                        case 2:
                            mi.mostrarMenuEmpleado();
                            break;
                    }
              }

        }
    }
}