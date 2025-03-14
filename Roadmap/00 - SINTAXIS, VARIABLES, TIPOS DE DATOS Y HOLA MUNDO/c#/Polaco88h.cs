﻿using System;

public class Class1
{
	public Class1()
	{
        /*
        EJERCICIO:
        *-Crea un comentario en el código y coloca la URL del sitio web oficial del
        *lenguaje de programación que has seleccionado.
        * -Representa las diferentes sintaxis que existen de crear comentarios
        *en el lenguaje(en una línea, varias...).
         *-Crea una variable(y una constante si el lenguaje lo soporta).
         *-Crea variables representando todos los tipos de datos primitivos
        *del lenguaje(cadenas de texto, enteros, booleanos...).
        * -Imprime por terminal el texto: "¡Hola, [y el nombre de tu lenguaje]!"
        **/

        //Documentacion oficial : https://learn.microsoft.com/es-es/dotnet/csharp/

        // Esto es un comentario de una sola línea

        /* esto es un 
        * comentario de multiples 
        * lineas 
        */
        var miVariable;
        const constantePy = 3.1416;
        Console.writeLine(constantePy);
        string cadena = "Hola mundo";
        int numeroEntero = 42;
        double numeroDecimal = 3.2020;
        bool esVerdadero = true;
        char caracter = 'A';

       Console.WriteLine("¡Hola, C#!");

    }
}
