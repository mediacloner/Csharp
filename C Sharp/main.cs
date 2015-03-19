/* Alex Sánchez 17/03/2014   */
/*...........................*/

//(8.2.1) Crea un programa que lea las tres primeras líneas del fichero 
//creado en el apartado anterior y las muestre en pantalla.

using System; 
using System.IO; // Para StreamReader

public class ReadFileTxt
{
    public static void Main()
    {
        StreamReader fichero;
        string linea;
        fichero = File.OpenText("registroDeUsuario.txt");
        linea = fichero.ReadLine();
        Console.WriteLine(linea);
        Console.WriteLine(fichero.ReadLine());
        Console.WriteLine(fichero.ReadLine());
        fichero.Close();
        Console.ReadLine();
    }
}