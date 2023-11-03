using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();
                opcion = Pantallas.PantallaPrincipal();

                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.IngresarNotas();
                        break;
                    case 2:
                        opcion = Pantallas.NotaMasAlta();
                        break;
                    case 3:
                        opcion = Pantallas.NotaMasBaja();
                        break;
                    case 4:
                        opcion = Pantallas.ListaDeEstudiantes();
                        break;
                    
                    case 0:
                        break;
                }
            } while (opcion != 5);


        }
    }
    }
