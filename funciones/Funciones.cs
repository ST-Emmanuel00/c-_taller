using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicios.funciones
{
    internal class Funciones
    {

        // En este apartado hacemos las funciones

        // Ejercicio 1

        public static string suma_tres_numeros()
        {
            Console.WriteLine("Ingrese 3 notas y devolvemos la suma");

            Console.Write("n1 = ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("n3 = ");
            double n3 = double.Parse(Console.ReadLine());


            double suma = n1 + n2 + n3;

            string mensaje = "Suma = " + suma;

            return mensaje;

        }

        // Ejercicio 2

        public static string sum_res_mul_div_dos_numeros()
        {

            Console.WriteLine("Ingrese 2 notas y devolvemos la suma, resta, multiplicacion y division");

            Console.Write("n1 = ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("n2 = ");
            double n2 = double.Parse(Console.ReadLine());


            double suma = n1 + n2;
            double resta = n1 - n2;
            double multiplicacion = n1 * n2;
            double division = n1 / n2;



            string mensaje = "Suma = " + suma + " Resta = " + resta + " Multiplicacion = " + multiplicacion + " Division = " + division;

            return mensaje;

        }


        // Ejercicio 3

        public static string nota_definitiva()
        {

            Console.WriteLine("Ingrese 3 notas y devolvemos la definitiva");


            Console.Write("Nota 1 = ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2 = ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3 = ");
            double nota3 = double.Parse(Console.ReadLine());

            string mensaje = " ";

            if ((nota1 > 5 || nota1 < 0) || (nota2 > 5 || nota2 < 0) || (nota3 > 5 || nota3 < 0))
            {

                mensaje = "La nota no es valida";

                return mensaje;


            }

            else
            {

                double definitiva = (nota1 + nota2 + nota3) / 3;

                mensaje = "Definitiva = " + definitiva;

                return mensaje;

            }

            


        }

        // Ejercicio 4

        public static string nota_definitiva2()
        {

            Console.WriteLine ("Ingrese 3 notas y devolvemos la definitiva con peso");

            string mensaje = " ";

            Console.Write("Nota 1 = ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2 = ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3 = ");
            double nota3 = double.Parse(Console.ReadLine());



            if ((nota1 > 5 || nota1 < 0) || (nota2 > 5 || nota2 < 0) || (nota3 > 5 || nota3 < 0))
            {

                mensaje = "La nota no es valida";

                return mensaje;


            }

            else
            {

                double definitiva = nota1 * 0.3 + nota2 * 0.2 + nota3 * 0.5;

                mensaje = "Definitiva = " + definitiva;

                return mensaje;

            }



        }

        // Ejercicio 5

        public static string velocidad()
        {

            try
            {

                Console.WriteLine("Calculo de la velocidad");

                string mensaje = " ";

                Console.Write("Distancia = ");
                double distancia = double.Parse(Console.ReadLine());

                if (distancia <= 0)
                {

                    throw new Exception("Distancia No puede ser menor a cero");

                }

                Console.Write("tiempo = ");
                double tiempo = double.Parse(Console.ReadLine());

                if (tiempo <= 0)
                {

                    throw new Exception("tiempo No puede ser menor a cero");

                }

                double velocidad = distancia / tiempo;

                mensaje = "Velocidad = " + velocidad + " km/h";

                return mensaje;


            }
            catch (Exception error)
            {

                Console.WriteLine("Error: " + error.Message);
                return "Error al calcular la velocidad.";

            }



        }

        // Ejercicio 6

        public static string valor_iva()
        {

            try
            {

                Console.WriteLine("Iva y descuento de una compra");

                Console.Write("Compra total = ");
                double compra = double.Parse(Console.ReadLine());
                string mensaje = "";

                if (compra <= 0) { throw new Exception("La compra no puede ser menor a cero"); }

                double iva = 1.19;

                Console.WriteLine("¿Autoriza descuento?");

                Console.WriteLine("Si para autorizar");
                Console.WriteLine("No para denegar");

                string autorizacion = Console.ReadLine();

                if (autorizacion.ToUpper() == "SI")
                {

                    Console.WriteLine("Autoriza descuento");

                    double descuento = 0.1;

                    double compra_descuento = (compra - (compra * descuento)) * iva;

                    mensaje = "Valor compra con descuento: " + compra_descuento + " Sin descuento = " + compra * iva + " Ahorro = " + ((compra * iva) - compra_descuento);

                    return mensaje;

                }

                else if (autorizacion.ToUpper() == "NO")
                {

                    Console.WriteLine("No autoriza descuento");


                    compra = compra * iva;

                    mensaje = "Valor compra: " + compra;

                    return mensaje;

                }

                else throw new Exception("Valor no valido");

            }

            catch (Exception error)
            {

                Console.WriteLine("Error: " + error.Message);
                return "Error en la compra";


            }
        }
        // Ejercicio 7

        public static string horas_a_segundos()
        {

            try
            {

                Console.WriteLine("Convertir horas:minutos:segundos a segundos");

                string mensaje;

                Console.Write("Horas = ");
                int horas = int.Parse(Console.ReadLine());

                if (horas < 0) { throw new Exception("Las horas no pueden ser menores a cero"); }

                Console.Write("Minutos = ");
                int minutos = int.Parse(Console.ReadLine());

                if (minutos < 0) { throw new Exception("Los minutos no pueden ser menores a cero"); }


                Console.Write("Segundos = ");
                int segundos = int.Parse(Console.ReadLine());

                if (segundos < 0) { throw new Exception("Los segundos no pueden ser menores a cero"); }

                Console.WriteLine(horas + ":" + minutos + ":" + segundos);

                int segundos_totales = ((horas * 60 * 60) + (minutos * 60) + segundos);

                mensaje = "Segundos totales = " + segundos_totales;


                return mensaje;

            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error en el calculo";

            }
        }
        // Ejercicio 8

        public static string inversion()
        {

            try
            {
                Console.WriteLine("Programa para calcular utilidad de mi inversion");

                string mensaje;

                Console.Write("Inversion = ");
                double inversion = double.Parse(Console.ReadLine());

                if (inversion < 0) { throw new Exception("Inversion no puede ser menor a cero"); };

                Console.Write("Meses = ");
                int meses = int.Parse(Console.ReadLine());

                if (meses < 0) { throw new Exception("Meses no puede ser menor a cero"); };


                for (int i = 0; i < meses; i++)
                {

                    inversion += inversion * 0.02;

                }

                mensaje = "Recibiras = " + inversion;

                return mensaje;

            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error en el calculo";

            }

        }
        
        
        // Ejercicio 9

        public static string comisiones ()
        {

            try
            {

                Console.WriteLine("Programa para calcular comisiones");

                string mensaje;
                double salario = 1160000;
                double comision = 0.1;

                Console.Write("Total de ventas = ");
                double ventas = double.Parse(Console.ReadLine());

                if (ventas < 0) { throw new Exception("Ventas no puede ser menor a cero"); }

                mensaje = "Comisiones = " + ventas * comision +  " Nomina total = " + (salario + (ventas * comision));

                return mensaje;
            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error en el calculo";

            }

        }
         // Ejercicio 10

        public static string descuento2 ()
        {

            try
            {

                Console.WriteLine("Programa para calcular descuento");

                string mensaje;
                double descuento = 0.15;

                Console.Write("Valor compra = ");
                double compra = double.Parse(Console.ReadLine());

                if (compra < 0) { throw new Exception("Compra no puede ser menor a cero"); }

                mensaje = "Valor a pagar = " + (compra - (compra * descuento)) + "$";

                return mensaje;


            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error calcular el descuento";

            }


        }
        // Ejercicio 11

        public static string calificacion_final ()
        {

            try
            {


                Console.WriteLine("Programa para calcular calificaciones del triemstre");

                string mensaje;
                double peso_calificacion_parcial = 0.55;
                double peso_examen_final = 0.3;
                double peso_trabajo_final = 0.15;

                Console.Write("Nota 1 = ");
                double nota1 = double.Parse(Console.ReadLine());

                if (nota1 < 0 || nota1 > 5) throw new Exception("Nota 1 no es valido");

                Console.Write("Nota 2 = ");
                double nota2 = double.Parse(Console.ReadLine());

                if (nota2 < 0 || nota2 > 5) throw new Exception("Nota 2 no es valido");


                Console.Write("Nota 3 = ");
                double nota3 = double.Parse(Console.ReadLine());

                if (nota3 < 0 || nota3 > 5) throw new Exception("Nota 3 no es valido");


                double calificaciones_parciales = (nota1 + nota2 + nota3) / 3;

                Console.Write("Examen final = ");
                double examen_final = double.Parse(Console.ReadLine());
                if (examen_final < 0 || examen_final > 5) throw new Exception("Nota examen final no es valido");


                Console.Write("Trabajo final = ");
                double trabajo_final = double.Parse(Console.ReadLine());
                if (trabajo_final < 0 || trabajo_final > 5) throw new Exception("Nota trabajo final no es valido");


                double calificacion_final = (calificaciones_parciales * peso_calificacion_parcial) + (examen_final * peso_examen_final) + (trabajo_final * peso_trabajo_final);


                mensaje = "Calificacion final = " + calificacion_final;

                return mensaje;

            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error calcular las calificaciones";

            }
        }

         // Ejercicio 12


        public static string procentaje_sexos ()
        {

            try
            {

                Console.WriteLine("Programa para decir que porcentaje de gente hay segun su sexo.");

                string mensaje;

                Console.Write("numero de hombres = ");
                double hombres = double.Parse(Console.ReadLine());

                if (hombres < 0 ) throw new Exception("No puede ser menor a cero");

                Console.Write("numero de mujeres = ");
                double mujeres = double.Parse(Console.ReadLine());

                if (mujeres < 0 ) throw new Exception("No puede ser menor a cero");

                double total = hombres + mujeres;

                double porcetaje_hombres = (hombres/total)*100;

                double porcetaje_mujeres = (mujeres/total)*100;

                mensaje = "% hombres: " + porcetaje_hombres + "%" +  " % mujeres: " + porcetaje_mujeres + "%";

                return mensaje;


            }

            catch (Exception error)
            {

                Console.WriteLine(error.Message);
                return "Error calcular";

            }
        }

        // Ejercicio 13

        public static string ejercicio_13 ()
        {

            Console.WriteLine("Programa 13 para Dada las horas trabajadas de una persona y el valor por hora. Calcular su salario e imprimirlo. ");

            Console.Write("Valor hora = ");
            double valor_hora = double.Parse(Console.ReadLine());
            if (valor_hora < 0 ) throw new Exception("No puede ser menor a cero");

            Console.Write("Numero horas = ");
            double horas = double.Parse(Console.ReadLine());
            if (horas < 0 ) throw new Exception("No puede ser menor a cero");


            double salario =  valor_hora * horas;

            string mensaje = "Salario = " + salario;

            return mensaje;

        }
        // Ejercicio 14

        public static string ejercicio_14()
        {

            try
            {
                Console.WriteLine("Programa 14. Se trata de escribir el algoritmo que permita emitir la factura correspondiente a una compra de varios artículos (4) determinados, del que se adquieren una o varias unidades. El IVA es del 19%.. ");

                double iva = 1.19;
                string mensaje;
                double total = 0;

                for (int i = 1; i <= 4; i++)

                {
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("0. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 0) break;

                    else if (opcion == 1)
                    {

                        Console.Write("Articulo = ");
                        string articulo = Console.ReadLine();

                        Console.Write("precio = ");
                        double precio = double.Parse(Console.ReadLine());

                        Console.Write("cantidad = ");
                        int cantidad = int.Parse(Console.ReadLine());

                        total = total + (precio * cantidad * iva);

                    }

                    else throw new Exception ("No es valido");

                }

                mensaje =  "compra total = " + total;

                return mensaje;

                }

                catch (Exception error)
                {

                    Console.WriteLine(error.Message);
                    return "Error calcular";

                }

            

        }

        // Ejercicio 15

        public static string ejercicio_15()
        {

            try
            {

                Console.WriteLine("15.\tSuponga que un conductor le pide a usted que le haga un algoritmo para \tcalcular cuánto le corresponde en un día trabajado, teniendo en cuenta que tiene derecho a el 19% del total \trecaudado.");

                double derecho = 0.19;
                string mensaje;

                Console.Write("Recaudo = ");
                double recaudo = double.Parse(Console.ReadLine());

                double total = recaudo * derecho;

                mensaje = "Derecho a: " + total + " Dolares";

                return mensaje;



            }

            catch (Exception error)
                {

                    Console.WriteLine(error.Message);
                    return "Error calcular";

                }
        }

        // Ejercicio 16

        public static string ejercicio_16 ()
        {

            double aporte_salud = 0.125;
            double aporte_pensiones = 0.16;
            string mensaje;

            try
            {

                

                Console.Write("Salario del empleado =");
                double salario = double.Parse(Console.ReadLine());
                if (salario < 0 ) throw new Exception("No puede ser menor a cero");

                Console.Write("Salario programado = ");
                double ahorro_programado = double.Parse(Console.ReadLine());
                if (ahorro_programado < 0 ) throw new Exception("No puede ser menor a cero");


                salario = salario - ((salario * aporte_pensiones) - (salario * aporte_salud));

                mensaje = $"Salario = {salario}";

                return mensaje;


            }

            catch (Exception error)
                {

                    mensaje = error.Message;
                    return "Error calcular";

                }
            

            


        }
        // Ejercicio 17

        public static string ejercicio_17()
        {

            string mensaje;
            double cuota1 = 0.4;
            double cuota2 = 0.25;
            double cuota3 = 0.2;
            double cuota4 = 0.15;

            try
            {

                
                Console.Write("Valor matricula =");
                double matricula = double.Parse(Console.ReadLine());
                if (matricula < 0 ) throw new Exception("No puede ser menor a cero");

                mensaje = $"\tCuota 1 = {matricula * cuota1}\t Cuota 2 = {matricula * cuota2}\t Cuota 3 = {matricula * cuota3}\t Cuota 4 = {matricula * cuota4}\t";
                
                return mensaje;
               
            }

             catch (Exception error)
                {

                    mensaje = error.Message;
                    return "Error calcular";

                }
            

        }
        // Ejercicio 18 

        public static string ejercicio_18 ()
        { 
            string mensaje;

            try
            {

                Console.Write("Nombre = ");
                string nombre = Console.ReadLine();

                Console.Write("Porgrama = ");
                string programa = Console.ReadLine();

                List<double> notas = new List<double>();

                double promedio = 0;
                double acumulado = 0;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"Nota {i} = ");
                    double nota = double.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 5 ) throw new Exception("No es valido ome");

                    notas.Add(nota);

                }

                foreach (double nota in notas)
                {

                    acumulado += nota;

                }

                promedio = acumulado / notas.Count();

                mensaje = $"Nombre {nombre}\t Programa = {programa}\t Promedio = {promedio}";

                return mensaje;


            }

            catch (Exception error)
            {

                mensaje = error.Message;
                return mensaje;

            }
        }

        // Ejercicio 20

        public static string ejercicio_20()
        {

            try
            {
                Console.WriteLine("Programa 14. Se trata de escribir el algoritmo que permita emitir la factura correspondiente a una compra de varios artículos (4) determinados, del que se adquieren una o varias unidades. El IVA es del 19%.. ");

                double iva = 1.19;
                string mensaje;
                double neto = 0;
                double decuentar = 0.2;
                double subtotal = 0;


                for (int i = 1; i <= 4; i++)

                {
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("0. Salir");

                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 0) break;

                    else if (opcion == 1)
                    {

                        Console.Write("precio = ");
                        double precio = double.Parse(Console.ReadLine());

                        Console.Write("cantidad = ");
                        int cantidad = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Aplica descuento?");
                        Console.WriteLine("1. para SI");
                        Console.WriteLine("2. para NO");

                        int descuento = int.Parse(Console.ReadLine());

                        if (descuento == 2) {
                                
                            subtotal = subtotal + (precio * cantidad);
                                
                        }
 

                        else if (descuento == 1)
                        {

                            subtotal = subtotal + (precio * cantidad - (precio * cantidad * decuentar) );

                        }

                        else throw new Exception ("No es valido puto");

                        neto = subtotal * iva;

                    }

                    else throw new Exception ("No es valido");

                }

                mensaje = $"Valor neto = {neto} \t Sub total = {subtotal} \t IVA = {subtotal * (iva - 1)} ";
                return mensaje;

            }
            
            catch (Exception error)
                {

                    Console.WriteLine(error.Message);
                    return "Error calcular";

                }

            

        }
            // Ejercicio 21
            // Ejercicio 22
            // Ejercicio 23
            // Ejercicio 24
        }
}
