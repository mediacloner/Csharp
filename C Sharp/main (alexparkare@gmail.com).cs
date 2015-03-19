/* Alex Sánchez 18/03/2014   */
/*...........................*/

//(8.4.1) Un programa que pida al usuario que teclee frases, y las almacene en el
//fichero "registro.txt", que puede existir anteriormente (y que no deberá borrarse, sino
//añadir al final de su contenido). Cada sesión acabará cuando el usuario pulse Intro sin
//teclear nada.

using System; 
using System.IO; // Para StreamReader

public class WriteExistFileTxt
{
   
    public static void Main()
    {   
        string frase="vacio";
        StreamWriter fichero;
        Console.WriteLine("Por favor, introduzca la información que desea insertar:");
        while (frase = null)
        {
            frase = Convert.ToString(Console.ReadLine());
            fichero = File.CreateText("prueba2.txt");
        }
        Console.WriteLine("Por favor, introduzca la segunda tanda de datos que desea insertar:");
        while (frase = null)
        {
            frase = Convert.ToString(Console.ReadLine());
            fichero = File.CreateText("prueba2.txt");
        } Console.WriteLine("Por favor, introduzca la tercera tanda de datos que desea insertar:");
        while (frase = null)
        {
            frase = Convert.ToString(Console.ReadLine());
            fichero = File.CreateText("prueba2.txt");
        }
        fichero.WriteLine("Primera línea"); 
        fichero.Close();
        fichero = File.AppendText("prueba2.txt"); 
        fichero.WriteLine("Segunda línea"); 
        fichero.Close();
}
}