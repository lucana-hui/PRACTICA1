using System;

public static class NumeroEnLetras
{
    static string[] unidades = {
        "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco",
        "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once",
        "Doce", "Trece", "Catorce", "Quince", "Dieciséis",
        "Diecisiete", "Dieciocho", "Diecinueve"
    };

    static string[] decenas = {
        "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta",
        "Setenta", "Ochenta", "Noventa"
    };

    public static void Main(string[] args)
    {
        Console.Write("Número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0 || numero > 99)
        {
            Console.WriteLine("Número fuera del rango admitido (0-99).");
        }
        else
        {
            string numeroEnLetras = ConvertirNumeroEnLetras(numero);
            Console.WriteLine(numeroEnLetras);
        }
    }

    public static string ConvertirNumeroEnLetras(int numero)
    {
        if (numero < 20)
        {
            return unidades[numero];
        }
        else
        {
            int unidad = numero % 10;
            int decena = (numero / 10) - 2; // Restamos 2 para obtener el índice correcto en el array de decenas
            string unidadEnLetras = (unidad > 0) ? unidades[unidad] : "";
            string decenaEnLetras = decenas[decena];

            return decenaEnLetras + (unidad > 0 ? " y " + unidadEnLetras : "");
        }
    }
}
