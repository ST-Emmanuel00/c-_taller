using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
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
            // Ejercicio 13
            // Ejercicio 14
            // Ejercicio 15
            // Ejercicio 16
            // Ejercicio 17
            // Ejercicio 18
            // Ejercicio 19
            // Ejercicio 20
            // Ejercicio 21
            // Ejercicio 22
            // Ejercicio 23
            // Ejercicio 24
        }
}
