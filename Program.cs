using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicios.funciones;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            // Menu principal

            for (int i = 1; i != 0; i++)
            {
                 
                Console.WriteLine("1. Para ejercicio 1");
                Console.WriteLine("2. Para ejercicio 2");
                Console.WriteLine("3. Para ejercicio 3");
                Console.WriteLine("4. Para ejercicio 4");
                Console.WriteLine("5. Para ejercicio 5");
                Console.WriteLine("6. Para ejercicio 6");
                Console.WriteLine("7. Para ejercicio 7");
                Console.WriteLine("8. Para ejercicio 8");
                Console.WriteLine("9. Para ejercicio 9");
                Console.WriteLine("10. Para ejercicio 10");
                Console.WriteLine("11. Para ejercicio 11");
                Console.WriteLine("12. Para ejercicio 12");
                Console.WriteLine("13. Para ejercicio 13");
                Console.WriteLine("14. Para ejercicio 14");
                Console.WriteLine("15. Para ejercicio 15");
                Console.WriteLine("16. Para ejercicio 16");
                Console.WriteLine("17. Para ejercicio 17");
                Console.WriteLine("18. Para ejercicio 18");
                Console.WriteLine("19. Para ejercicio 19");
                Console.WriteLine("20. Para ejercicio 20");
                Console.WriteLine("21. Para ejercicio 21");
                Console.WriteLine("22. Para ejercicio 22");
                Console.WriteLine("23. Para ejercicio 23");
                Console.WriteLine("24. Para ejercicio 24");
                Console.WriteLine("0. Para Salir");


                int opcion = int.Parse(Console.ReadLine());
                string mensaje;

                if (opcion == 0) break;

                else if (opcion > 0)
                {


                    switch (opcion)
                    {

                        case 1:
                            Console.WriteLine("Ejercicio 1");

                            mensaje = Funciones.suma_tres_numeros();
                            Console.WriteLine(mensaje);

                            break;

                        case 2:
                            Console.WriteLine("Ejercicio 2");

                            mensaje = Funciones.sum_res_mul_div_dos_numeros();
                            Console.WriteLine(mensaje);

                            break;

                        case 3:
                            Console.WriteLine("Ejercicio 3");

                            mensaje = Funciones.nota_definitiva();
                            Console.WriteLine(mensaje);

                            break;

                        case 4:
                            Console.WriteLine("Ejercicio 4");

                            mensaje = Funciones.nota_definitiva2();
                            Console.WriteLine(mensaje);

                            break;

                        case 5:
                            Console.WriteLine("Ejercicio 5");
                            mensaje = Funciones.velocidad();
                            Console.WriteLine(mensaje);
                            break;

                        case 6:
                            Console.WriteLine("Ejercicio 6");

                            mensaje = Funciones.valor_iva();
                            Console.WriteLine(mensaje);

                            break;

                        case 7:
                            Console.WriteLine("Ejercicio 7");

                            mensaje = Funciones.horas_a_segundos();
                            Console.WriteLine(mensaje);

                            break;

                        case 8:
                            Console.WriteLine("Ejercicio 8");

                            mensaje = Funciones.inversion();
                            Console.WriteLine(mensaje);

                            break;

                        case 9:
                            Console.WriteLine("Ejercicio 9");

                            mensaje = Funciones.comisiones();
                            Console.WriteLine(mensaje);

                            break;

                        case 10:
                            Console.WriteLine("Ejercicio 10");

                            mensaje = Funciones.descuento2();
                            Console.WriteLine(mensaje);

                            break;

                        case 11:
                            Console.WriteLine("Ejercicio 11");

                            mensaje = Funciones.calificacion_final();
                            Console.WriteLine(mensaje);

                            break;

                        case 12:
                            Console.WriteLine("Ejercicio 12");

                            mensaje = Funciones.procentaje_sexos();
                            Console.WriteLine(mensaje);
                            break;

                        case 13:
                            Console.WriteLine("Ejercicio 13");

                            mensaje = Funciones.ejercicio_13();
                            Console.WriteLine(mensaje);

                            break;

                        case 14:
                            Console.WriteLine("Ejercicio 14");

                            mensaje = Funciones.ejercicio_14();
                            Console.WriteLine(mensaje);

                            break;

                        case 15:
                            Console.WriteLine("Ejercicio 15");

                            mensaje = Funciones.ejercicio_15();
                            Console.WriteLine(mensaje);

                            break;

                        case 16:
                            Console.WriteLine("Ejercicio 16");

                            mensaje = Funciones.ejercicio_16();
                            Console.WriteLine(mensaje);

                            break;

                        case 17:
                            Console.WriteLine("Ejercicio 17");

                            mensaje = Funciones.ejercicio_17();
                            Console.WriteLine(mensaje);

                            break;

                        case 18:
                            Console.WriteLine("Ejercicio 18");

                            mensaje = Funciones.ejercicio_18();
                            Console.WriteLine(mensaje);

                            break;

                        case 19:
                            Console.WriteLine("Ejercicio 19");
                            break;

                        case 20:
                            Console.WriteLine("Ejercicio 20");

                            mensaje = Funciones.ejercicio_20();
                            Console.WriteLine(mensaje);
                            break;


                        default:
                            Console.WriteLine("Opción inválida");
                            break;



                    }



                };

            }

        }
    }
}
