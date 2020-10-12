using EjIntegrador.Entidades;
using EjVtaRepuestos;
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
                string listado = null;
                int eleccion = ConsolaHelper.PedirNumero("\nSelecione opción: \n1- Agregar Alumno \n" +
                    "2- Agregar Empleado \n3- Eliminar Alumno \n4- Eliminar Empleado \n5- Modificar Empleado \n" +
                    "6- Traer Alumnos \n7- Traer Empleados x legajo \n8- Traer Empleados \n" +
                    "9- Traer Empleados x nombre \n10- Apagar \n");

                if (eleccion > 10 || eleccion < 0)
                    ConsolaHelper.Mensaje("\n--Debe ingresar una opción válida--\n");

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
                                try
                                {
                                    f1.AgregarEmpleado(
                                        ConsolaHelper.PedirTexto("Ingrese tipo de empleado: BEDEL - DOCENTE - DIRECTIVO"),
                                        ConsolaHelper.PedirTexto("Ingrese nombre del empleado"),
                                        ConsolaHelper.PedirTexto("Ingrese apellido del empleado"),
                                        ConsolaHelper.PedirFecha("Ingrese fecha de nacimiento del empleado"),
                                        DateTime.Today,
                                        ConsolaHelper.PedirNumero("Ingrese legajo"),
                                        ConsolaHelper.PedirTexto("En caso de ser BEDEL ingrese apodo, caso contrario presione ENTER"));
                                        ConsolaHelper.Mensaje("Se agregó el nuevo empleado");
                                }catch (Exception ex1) { ConsolaHelper.Mensaje(ex1.Message); }
                                    break;
                            case 3:
                                try
                                {
                                    f1.EliminarAlumno(ConsolaHelper.PedirNumero("Ingrese código del alumno a eliminar"));
                                    ConsolaHelper.Mensaje("Se ha eliminado el alumno");
                                } catch (Exception ex1) { ConsolaHelper.Mensaje(ex1.Message); }
                                break;
                            case 4:
                                try
                                {
                                    f1.EliminarEmpleado(ConsolaHelper.PedirNumero("Ingrese legajo del empleado"));
                                    ConsolaHelper.Mensaje("Se ha eliminado el empleado");
                                } catch(Exception ex1) { ConsolaHelper.Mensaje(ex1.Message); }
                                break;
                            case 5:
                                try
                                {
                                    f1.ModificarEmpleado(
                                        ConsolaHelper.PedirNumero("Ingrese legajo del empleado a modificar"),
                                        ConsolaHelper.PedirTexto("Ingrese nombre"),
                                        ConsolaHelper.PedirTexto("Ingrese apellido"),
                                        ConsolaHelper.PedirFecha("Ingrese nacimiento"));
                                } catch (Exception ex1) { ConsolaHelper.Mensaje(ex1.Message); }
                                break;
                            case 6:
                                foreach (Alumno al in f1.TraerAlumnos())
                                {
                                    listado += (al.ToString() + "\n");
                                }
                                ConsolaHelper.Mensaje(listado);
                                break;
                            case 7:
                                foreach (Empleado emp in f1.TraerEmpleadoPorLegajo(ConsolaHelper.PedirNumero("Ingrese legajo")))
                                {
                                    listado += (emp.ToString() + "\n");
                                }
                                ConsolaHelper.Mensaje(listado);
                                break;
                            case 8:
                                foreach (Empleado emp in f1.TraerEmpleado())
                                {
                                    listado += (emp.ToString() + "\n");
                                }
                                ConsolaHelper.Mensaje(listado);
                                break;
                            case 9:
                                foreach (Empleado emp in f1.TraerEmpleadoPorNombre(ConsolaHelper.PedirTexto("Ingrese nombre")))
                                {
                                    listado += (emp.ToString() + "\n");
                                }
                                ConsolaHelper.Mensaje(listado);
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
