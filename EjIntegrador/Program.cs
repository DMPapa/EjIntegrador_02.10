using EjIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador
{
    class Program
    {
        static void Main(string[] args)
        {

            Facultad f1 = new Facultad("La Dieguito Maradona", 1);         

            ConsolaHelper.PedirTexto("Bienvenido a la facultad: " + f1.Nombre + ". Presione -ENTER-");

            bool finalizar = false;
            do
            {
                int eleccion = ConsolaHelper.PedirNumero("\nSelecione opción: \n1- Agregar Alumno \n" +
                    "2- Agregar Empleado \n3- Eliminar Alumno \n4- Eliminar Empleado \n5- Modificar Empleado \n" +
                    "6- Traer Alumnos \n7- Traer Empleados x legajo \n8- Traer Empleados \n" +
                    "9- Traer Empleados x nombre \n10- Apagar \n");

                if (eleccion > 10 || eleccion < 0)
                    throw new Exception("\n--Debe ingresar una opción válida--\n");

                else
                    switch (eleccion)
                    {
                        case 1:
                            f1.AgregarAlumno(
                                ConsolaHelper.PedirTexto("Ingrese nombre del alumno"), 
                                ConsolaHelper.PedirTexto("Ingrese apellido del alumno"), 
                                ConsolaHelper.PedirFecha("Ingrese fecha de nacimiento"), 
                                ConsolaHelper.PedirNumero("Ingrese código del alumno"));
                            break;
                        case 2:
                            f1.AgregarEmpleado(
                                ConsolaHelper.PedirTexto("Ingrese tipo de empleado: BEDEL - DOCENTE - DIRECTIVO"),
                                ConsolaHelper.PedirTexto("Ingrese nombre del empleado"),
                                ConsolaHelper.PedirTexto("Ingrese apellido del empleado"),
                                ConsolaHelper.PedirFecha("Ingrese fecha de nacimiento del empleado"),
                                DateTime.Today,
                                ConsolaHelper.PedirNumero("Ingrese legajo"),
                                ConsolaHelper.PedirTexto("En caso de ser BEDEL ingrese apodo, caso contrario presione ENTER"));
                            break;
                        case 3:
                            f1.EliminarAlumno(ConsolaHelper.PedirNumero("Ingrese código del alumno a eliminar"));
                            break;
                        case 4:
                            f1.EliminarEmpleado(ConsolaHelper.PedirNumero("Ingrese legajo del empleado"));
                            break;
                        case 5:
                            f1.ModificarEmpleado(
                                ConsolaHelper.PedirNumero("Ingrese legajo del empleado a modificar"),
                                ConsolaHelper.PedirTexto("Ingrese nombre"),
                                ConsolaHelper.PedirTexto("Ingrese apellido"),
                                ConsolaHelper.PedirFecha("Ingrese nacimiento"));
                            break;
                        case 6:
                            f1.TraerAlumnos();
                            break;
                        case 7:
                            f1.TraerEmpleadoPorLegajo(ConsolaHelper.PedirNumero("Ingrese legajo"));
                            break;
                        case 8:
                            f1.TraerEmpleado();
                            break;
                        case 9:
                            f1.TraerEmpleadoPorNombre(ConsolaHelper.PedirTexto("Ingrese nombre"));
                            break;
                        case 10:
                            finalizar = true;
                            ConsolaHelper.Mensaje("\nGracias por usar la app");
                            break;
                    }
            } while (finalizar == false);
        }

    }
}
