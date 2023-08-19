using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
        // declaracion de varibales de texto
        string? nombre ;
        string? apellido;

        // Declaracion de variables de texto desde codigo
        string? codigo_estudiantil = "U20231258";
        string? becado = "no";

        // Declaracion de variables tipo entera desde la terminal
        int edad;

        // Declaracion de variables de tipo enteras desde codigo
        int años_ingreso = 2023;
        int año_egreso = 2024;

        // Declaracion de varibles decimales capturando desde la terminal
        double mensualidad ;

        // Declaracion de variables decimales desde codigo
        double transporte = 2.50 ;
        double alimentacion = 3.75 ;

        // Declaracion de variables de tiempo o tiempo
        DateTime FechaActual = DateTime.Now ;
        DateTime FechaEspecifica = new DateTime(23, 8, 19 ,16 , 20, 00);



        //obtencion de datos desde la terminal
        Console.WriteLine("ingrese su nombre:");
        nombre = Convert.ToString(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("ingrese su apellido:");
        apellido = Convert.ToString(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Ingrese su mensualidad universitaria: ");
        mensualidad =Convert.ToDouble(Console.ReadLine());


        // Impresion de datos
        Console.WriteLine ("Su nombre es : " + nombre);
        Console.WriteLine ("Su apellido es: " + apellido);
        Console.WriteLine ("Su codigo estudiantil es: " + codigo_estudiantil);
        Console.WriteLine ("es bacado: " + becado);
        Console.WriteLine ("Su edad es : " + edad);
        Console.WriteLine ("El año en que ingreso fue : " + años_ingreso);
        Console.WriteLine ("Su año de egreso sera : " + año_egreso);
        Console.WriteLine ("Su mensualidad universitaria es : " + mensualidad);
        Console.WriteLine ("Su gasto diario de transporte es : " + transporte);
        Console.WriteLine ("su gasto diario de alimentacion es " + alimentacion);
        Console.WriteLine ("La fecha y tiempo de impresion de datos es " + FechaActual);
        Console.WriteLine ("La fecha que termina la practica es : " + FechaEspecifica);
        Console.WriteLine ("******************Fin de impresion***********************");


        Console.WriteLine ("***********************Inicio de impresion*************************");
        // Aplicacion de funciones en cadena

        // Funcion de comparacion cadenas de texto
        bool cadenaComparativa = nombre == apellido;

        // Funcion minuscula
        string? funcionMinuscula1 = nombre.ToLower();
        string? funcionMinuscula2 = apellido.ToLower();

        // Funcion de mayuscula
        string? funcionMayuscula1 = nombre.ToUpper();
        string? funcionMayuscula2 = apellido.ToUpper();

        // Funcion concatenado
        string? cadenaConcatenada = nombre + " " + apellido ;

        // Funcion de tamaño de cadena
        int llongitudCdena1 = nombre.Length;
        int llongitudCdena2 = apellido.Length;

        Console.WriteLine ("Comparacion: "+ cadenaComparativa);
        Console.WriteLine ("Mayuscula Nombre y Apellido: "+ funcionMayuscula1 + " "+ funcionMayuscula2);
        Console.WriteLine ("Minuscula Nombre y Apellido : "+ funcionMinuscula1+ " "+ funcionMinuscula2);
        Console.WriteLine ("Concatenacion: "+ cadenaConcatenada);
        Console.WriteLine ("La longitus de datos de nombre es: "+ llongitudCdena1);
        Console.WriteLine ("La longitus de datos de apellido es: "+ llongitudCdena2);
        Console.WriteLine ("*****************Fin de la impresion********************");


        }
    }
}