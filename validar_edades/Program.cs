Console.Write("Introduce tu edad: ");
string entrada = Console.ReadLine();

if (ValidarEdad(entrada))
{
    Console.WriteLine("¡Edad válida!");
}
else
{
    Console.WriteLine("Edad no válida. Debe ser un número entero positivo.");
}

bool ValidarEdad(string texto)
{
    if (int.TryParse(texto, out int edad))
    {
        return edad >= 0 && edad <= 100;
    }
    return false;
}