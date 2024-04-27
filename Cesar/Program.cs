using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el texto cifrado:");
        string textoCifrado = Console.ReadLine();

        Console.WriteLine("Ingrese la clave de cifrado:");
        int clave = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Texto descifrado:");
        Console.WriteLine(DesencriptarCesar(textoCifrado, clave));
    }

    static string DesencriptarCesar(string textoCifrado, int clave)
    {
        string alfabeto = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
        string textoDescifrado = "";
        foreach (char c in textoCifrado)
        {
            if (alfabeto.Contains(c.ToString().ToLower())) 
            {
             int indice = (alfabeto.IndexOf(c.ToString().ToLower()) - clave + alfabeto.Length) % alfabeto.Length;
             char caracterDescifrado = alfabeto[indice];
                if (char.IsUpper(c))
                {
                    caracterDescifrado= char.ToUpper(c);
                }
                textoDescifrado += caracterDescifrado;
            }else
            {
                textoDescifrado += c;
            }
            return textoDescifrado;
        }

        return textoDescifrado;
    }
}
