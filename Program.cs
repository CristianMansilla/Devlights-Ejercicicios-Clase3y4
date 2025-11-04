//Ejercicios Clase 3 y 4

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-----------------------------");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Devlights Bootcamp 4.0 - Ejercicios de la clase 3 y 4");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Alumno: Cristian Mansilla");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-----------------------------");
Console.ResetColor();

#region PROMEDIO ALUMNO
/*
1 - Dado que se tiene almacenado en una lista, los resultados de los últimos 10
exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de
los exámenes y el promedio resultante.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("1) PROMEDIO ALUMNO");
Console.ResetColor();

var notas = new List<decimal>();
decimal promedio;
Console.WriteLine("Notas:");
notas.Add(5.0m);
notas.Add(6.0m);
notas.Add(7.0m);
notas.Add(8.0m);
notas.Add(9.0m);
notas.Add(9.5m);
notas.Add(9.6m);
notas.Add(9.7m);
notas.Add(9.8m);
notas.Add(9.9m);
promedio = notas.Sum() / notas.Count;

for (int i = 0; i < notas.Count; i++)
{
    Console.WriteLine($"{i+1} - {notas[i]}");
}
Console.WriteLine($"El promedio de las últimas {notas.Count} notas es: {promedio}");
#endregion
Console.WriteLine();
Console.WriteLine();
#region EDADES PERSONAS
/*
2 - Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla
cuántos son mayores de edad y cuántos no.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("2) EDADES PERSONAS");
Console.ResetColor();
int mayoresEdad = 0;
var edades = new List<int>
{
    65,
    80,
    45,
    18,
    5,
    6,
    7,
    8,
    9,
    10,
    11,
    12,
    13,
    14,
    15,
    16,
    17,
    18,
    19,
    20
};
foreach (int edad in edades)
{
    if (edad >= 18)
    {
        mayoresEdad++;
    }
}
Console.WriteLine($"Personas mayores de edad: {mayoresEdad}");
Console.WriteLine($"Personas menores de edad: {edades.Count - mayoresEdad}");
#endregion
