//Ejercicios Clase 3 y 4

using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-----------------------------");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Devlights Bootcamp 4.0 - Ejercicios de la clase 3 y 4");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Alumno: Cristian Mansilla");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("-----------------------------");
Console.ResetColor();

#region VARIABLES GLOBALES
string? valor;
char letra;
int cantidadPalabras;
int cantidadNumeros;
bool continuar;
Random rnd = new Random();
#endregion

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
Console.WriteLine();
Console.WriteLine();
#region NOMBRE CON MÁS LETRAS
/*
3 - Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que
tenga menos letras de todos.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("3) NOMBRE CON MÁS LETRAS");
Console.ResetColor();
var nombresEstudiantes = new List<string>
{
    "Juan",
    "Pedro",
    "María",
    "Damian",
    "Roberto",
    "Cristian",
    "Laura",
    "Luis"
};
int minLen = nombresEstudiantes.Min(n => n.Length);
int maxLen = nombresEstudiantes.Max(n => n.Length);
var masCortos = nombresEstudiantes.Where(n => n.Length == minLen).ToList();
var masLargos = nombresEstudiantes.Where(n => n.Length == maxLen).ToList();
string textoEstudianteNombreMasCorto = masCortos.Count > 1 ? "Estudiantes con nombres más cortos" : "Estudiante con nombre más corto";
string textoEstudianteNombreMasLargo = masLargos.Count > 1 ? "Estudiantes con nombres más largos" : "Estudiante con nombre más largo";
Console.WriteLine($"{textoEstudianteNombreMasCorto}: {string.Join(", ", masCortos)} ({minLen} letras)");
Console.WriteLine($"{textoEstudianteNombreMasLargo}: {string.Join(", ", masLargos)} ({maxLen} letras)");
#endregion
Console.WriteLine();
Console.WriteLine();
#region LISTA SUPERMERCADO
/*
4 - Crear una variable para guardar los nombres de elementos para una “lista de
supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a
comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo
e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al
finalizar mostrar por pantalla los elementos que no compró y los que compró, pero
no estaban en la lista. Si se quiere, mostrar también todos los elementos que el
usuario compró. Para salir el usuario debe ingresar “fin”.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("4) LISTA SUPERMERCADO");
Console.ResetColor();
bool continua = true;
string? encontrado;
var elementosComprados = new List<string>();
var elementosNoListados = new List<string>();
var elementosLista = new List<string>
{
    "Arroz",
    "Pan",
    "Fideo",
    "Papel Higienico",
    "Papa",
    "Cebolla",
    "Carne Molida",
    "Coca Cola"
};
var copiaElementosOriginales = new List<string>(elementosLista);
while (continua)
{
    Console.WriteLine("Ingrese el nombre de un elemento a comprar o 'fin' para salir:");
    valor = Console.ReadLine();
    if (!string.IsNullOrEmpty(valor) && valor.All(char.IsLetter))
    {
        if (valor.Equals("fin"))
        {
            Console.WriteLine("Saliendo del programa!");
            Console.WriteLine("");
            continua = false;
            break;
        }
        elementosComprados.Add(valor);
        encontrado = elementosLista.FirstOrDefault(e => e.Equals(valor, StringComparison.OrdinalIgnoreCase));
        if (encontrado != null)
        {
            elementosLista.Remove(encontrado);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"'{valor}' estaba en la lista y fue marcado como comprado.");
            Console.ResetColor();
            Console.WriteLine();
        }
        else
        {
            elementosNoListados.Add(valor);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"'{valor}' no estaba en la lista. Se agregó como compra extra.");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Debes ingresar una palabra");
        Console.WriteLine();
    }
}
Console.WriteLine($"Lista de elementos a comprar:");
Console.WriteLine(string.Join(", ", copiaElementosOriginales));
Console.WriteLine();
if (elementosComprados.Count > 0)
{
    Console.WriteLine($"Los elementos comprados son:");
    Console.WriteLine(string.Join(", ", elementosComprados));
    Console.WriteLine();
}
Console.WriteLine($"Los elementos que no fueron comprados son:");
Console.WriteLine(string.Join(", ", elementosLista));
Console.WriteLine();
if (elementosNoListados.Count > 0)
{
    Console.WriteLine($"Los elementos extras comprados son:");
    Console.WriteLine(string.Join(", ", elementosNoListados));
}
#endregion
Console.WriteLine();
Console.WriteLine();
#region MATRIZ 5 X 5
/*
5 - Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares
pares. Imprimir la matriz por pantalla.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("5) MATRIZ 5 X 5");
Console.ResetColor();

char[,] matriz5x5 = new char[5, 5];

for (int i = 0; i < matriz5x5.GetLength(0); i++)
{
    for (int j = 0; j < matriz5x5.GetLength(1); j++)
    {
        matriz5x5[i, j] = ((i + j) % 2 == 0) ? 'P' : 'I';
    }
}

for (int i = 0; i < matriz5x5.GetLength(0); i++)
{
    for (int j = 0; j < matriz5x5.GetLength(1); j++)
    {
        Console.Write($"{matriz5x5[i, j]} ");
    }
    Console.WriteLine();
}
#endregion
Console.WriteLine();
Console.WriteLine();
#region MATRIZ 5 X 7
/*
6 - Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de
la semana. La estructura es para registrar la temperatura diaria de una cabina de
pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma
aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se
ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el
principio del programa, no es necesario pedir los valores al usuario para cada
posición). Se nos pide hacer lo siguiente:
a. Obtener la temperatura más alta y baja de la semana y que día se produjo
(lunes, martes, etc.)
b. Promedio de temperatura de la semana.
c. Temperatura más alta del mes y su día.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("6) MATRIZ 5 X 7");
Console.ResetColor();
int[,] matriz5x7 = new int[5, 7];
int temperaturaMaxima;
int temperaturaMinima;
int temperaturaMaximaMes = 0;
int diaTemMax;
int diaTemMin;
int dia = 0;
int semana = 0;
decimal promedioTemperaturaSemanal;
string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

for (int i = 0; i < matriz5x7.GetLength(0); i++)
{
    for (int j = 0; j < matriz5x7.GetLength(1); j++)
    {
        if(i == 4 && j > 2)
        {
            matriz5x7[i, j] = 0;
        }
        else
        {
            matriz5x7[i, j] = rnd.Next(7, 39);
        }
            
    }
}
Console.WriteLine("Temperaturas registradas en el mes de Mayo:");
for (int i = 0; i < matriz5x7.GetLength(0); i++)
{
    for (int j = 0; j < matriz5x7.GetLength(1); j++)
    {
        if(j == 0)
        {
            Console.Write($"{matriz5x7[i, j]} ");
        }
        else
        {
            Console.Write($"{matriz5x7[i, j],8} ");
        }
        
    }
    Console.WriteLine();
}

for (int i = 0; i < matriz5x7.GetLength(0); i++)
{
    temperaturaMaxima = 0;
    temperaturaMinima = int.MaxValue;
    diaTemMax = 0;
    diaTemMin = 0;
    promedioTemperaturaSemanal = 0;
    for (int j = 0; j < matriz5x7.GetLength(1); j++)
    {
        promedioTemperaturaSemanal += matriz5x7[i, j];
        if (matriz5x7[i,j] > temperaturaMaxima)
        {
            temperaturaMaxima = matriz5x7[i,j];
            diaTemMax = j;
        }

        if (matriz5x7[i, j] < temperaturaMinima && matriz5x7[i, j] != 0)
        {
            temperaturaMinima = matriz5x7[i, j];
            diaTemMin = j;
        }

        if(matriz5x7[i, j] > temperaturaMaximaMes)
        {
            temperaturaMaximaMes = matriz5x7[i, j];
            dia = j;
            semana = i;
        }
    }
    if (i == 4)
    {
        promedioTemperaturaSemanal /= 3;
    }
    else
    {
        promedioTemperaturaSemanal /= 7;
    }

    Console.WriteLine();
    Console.WriteLine($"Semana {i+1}");
    Console.WriteLine($"Temperatura máxima: {temperaturaMaxima}° se produjo el día: {dias[diaTemMax]}");
    Console.WriteLine($"Temperatura mínima: {temperaturaMinima}° se produjo el día: {dias[diaTemMin]}");
    Console.WriteLine($"El promedio de la temperatura semanal es: {promedioTemperaturaSemanal:F2}");
}
Console.WriteLine();
Console.WriteLine($"La temperatura máxima del mes fue de: {temperaturaMaximaMes}° y se produjo la semana {semana+1}, el día: {dias[dia]}");
#endregion
Console.WriteLine();
Console.WriteLine();
#region TABLAS 1 AL 9
/*
7 - Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera
fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en
la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado
usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3,
etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz
por pantalla
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("7) TABLAS 1 AL 9");
Console.ResetColor();

int[,] tablas1al9 = new int[10, 10];

for (int i = 0; i < tablas1al9.GetLength(0); i++)
{
    for (int j = 0; j < tablas1al9.GetLength(1); j++)
    {
        if(i == 0)
        {
            tablas1al9[i, j] = j;
        }else if(j == 0){
            tablas1al9[i, j] = i;
        }
        else
        {
            tablas1al9[i, j] = tablas1al9[i, 0] * tablas1al9[0, j];
        }
    }
}

for (int i = 0; i < tablas1al9.GetLength(0); i++)
{
    for (int j = 0; j < tablas1al9.GetLength(1); j++)
    {
        if (j == 0)
        {
            Console.Write($"{tablas1al9[i, j]} ");
        }
        else
        {
            Console.Write($"{tablas1al9[i, j],8} ");
        }
    }
    Console.WriteLine();
}
#endregion
Console.WriteLine();
Console.WriteLine();
#region ADIVINAR X
/*
8 - Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la
cantidad que el programador decida, pero no más de la mitad de los lugares
disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una
X, ingresando la fila y la columna por separado. Informar si acertó o no por cada
ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya
guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se
terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la
matriz con sus correspondientes X, mostrando un * donde no haya nada.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("8) ADIVINAR X");
Console.ResetColor();

char[,] matrizX = new char[10, 10];
char[,] matrizXCopia = new char[10, 10];
int cantidadX = 0;
int cantidadDeJuegos;
int colocadas = 0;
int intentos = 3;
int filaAdivinar;
int columnaAdivinar;
cantidadNumeros = 0;

while (cantidadNumeros < 1)
{
    Console.WriteLine("¿Cuantas 'X' desea esconder?");
    valor = Console.ReadLine();
    if (int.TryParse(valor, out cantidadX))
    {
        if (cantidadX <= 49)
        {
            cantidadNumeros++;
        }
        else
        {
            Console.WriteLine("Debes ingresar un valor menor a 50");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Debes ingresar un número entero");
        Console.WriteLine();
    }
}

for (int i = 0; i < matrizX.GetLength(0); i++)
{
    for (int j = 0; j < matrizX.GetLength(1); j++)
    {
        matrizX[i, j] = '*';
    }
}

while (colocadas < cantidadX)
{
    int fila = rnd.Next(0, 10);
    int columna = rnd.Next(0, 10);

    if (matrizX[fila, columna] == '*')
    {
        matrizX[fila, columna] = 'X';
        colocadas++;
    }
}
Array.Copy(matrizX, matrizXCopia, matrizX.Length);
Console.WriteLine();
Console.WriteLine("Encontremos todas las 'X' escondidas en el tablero.");
Console.WriteLine("Tendrás 3 intentos para fallar.");
Console.WriteLine();

cantidadDeJuegos = cantidadX;
while (intentos > 0 && cantidadDeJuegos > 0)
{
    while (true)
    {
        Console.Write("Ingrese la posición de la FILA (0-9): ");
        valor = Console.ReadLine();

        if (int.TryParse(valor, out filaAdivinar) && filaAdivinar >= 0 && filaAdivinar <= 9)
            break;

        Console.WriteLine("Fila inválida. Debe ser un número entre 0 y 9.\n");
    }
    while (true)
    {
        Console.Write("Ingrese la posición de la COLUMNA (0-9): ");
        valor = Console.ReadLine();

        if (int.TryParse(valor, out columnaAdivinar) && columnaAdivinar >= 0 && columnaAdivinar <= 9)
            break;

        Console.WriteLine("Columna inválida. Debe ser un número entre 0 y 9.\n");
    }
    Console.WriteLine($"Entrada válida: fila {filaAdivinar}, columna {columnaAdivinar}\n");


    if (matrizXCopia[filaAdivinar, columnaAdivinar] == 'V')
    {
        Console.WriteLine("Esa 'X' ya la habías encontrado. Elegí otra posición.\n");
        continue;
    }

    string resultadoEvaluado = matrizX[filaAdivinar, columnaAdivinar] == 'X' ? "Acertó" : "Falló";
    Console.WriteLine(resultadoEvaluado);
    if (resultadoEvaluado == "Falló")
    {
        intentos--;
        if (intentos > 0)
            Console.WriteLine($"Te quedan {intentos} intentos");
    }

    if (resultadoEvaluado == "Acertó")
    {
        matrizXCopia[filaAdivinar, columnaAdivinar] = 'V';
        cantidadDeJuegos--;
        if(cantidadDeJuegos > 0)
        Console.WriteLine($"Te restan adivinar {cantidadDeJuegos} 'X'");
    }
    Console.WriteLine();
}
if(intentos == 0)
{
    Console.WriteLine("Game Over!");
}
else
{
    Console.WriteLine("Felicitaciones lograste vencer el juego.");
}
Console.WriteLine();
Console.WriteLine("Tablero");
for (int i = 0; i < matrizX.GetLength(0); i++)
{
    for (int j = 0; j < matrizX.GetLength(1); j++)
    {
        if (j == 0)
        {
            Console.Write($"{matrizX[i, j]} ");
        }
        else
        {
            Console.Write($"{matrizX[i, j],4} ");
        }

    }
    Console.WriteLine();
}
#endregion
Console.WriteLine();
Console.WriteLine();
#region DICCIONARIO CALIFICACIONES
/*
9 - Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del
alumno y el valor sea su nota. El programa debe permitir:
a. Agregar alumnos y sus notas.
b. Mostrar el promedio general del curso.
c. Indicar el alumno con mejor nota y el de peor nota.
d. Hint: usar Dictionary<string, double> y recorrer con foreach
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("9) DICCIONARIO CALIFICACIONES");
Console.ResetColor();

cantidadNumeros = 0;
string nombreAlumno = "";
double nota = 0;
double sumaNotas = 0;
int cantidadNotas = 0;
double promedioNotas;
Dictionary<string, double> calificaciones = new Dictionary<string, double>();
double mejorNota = 0;
string alumnoMejorNota = "";
double peorNota = double.MaxValue;
string alumnoPeorNota = "";

Console.WriteLine("Sistema de gestión de alumnos.");
while (cantidadNumeros < 1)
{
    Console.WriteLine("\nAcción a realizar:");
    Console.WriteLine("a. Agregar alumnos y sus notas.");
    Console.WriteLine("b. Mostrar el promedio general del curso.");
    Console.WriteLine("c. Indicar el alumno con mejor nota y el de peor nota.");
    Console.WriteLine("d. Salir.");
    valor = Console.ReadLine();
    if (char.TryParse(valor, out letra))
    {
        if (letra == 'a' || letra == 'b' || letra == 'c' || letra == 'd')
        {
            switch (letra)
            {
                case 'a':
                    continuar = true;
                    do
                    {
                        while (true)
                        {
                            Console.Write("\nIngrese el nombre del alumno: ");
                            valor = Console.ReadLine();
                            nombreAlumno = valor;
                            if (!string.IsNullOrWhiteSpace(nombreAlumno) && nombreAlumno.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                            {
                                nombreAlumno = nombreAlumno.Trim();
                                break;
                            }
                            Console.WriteLine("Nombre inválido. Solo letras y espacios.\n");
                        }
                        while (true)
                        {
                            Console.Write("Nota del alumno:");
                            valor = Console.ReadLine();
                            if (double.TryParse(valor, NumberStyles.Float, CultureInfo.CurrentCulture, out nota) || double.TryParse(valor?.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out nota))
                            {
                                if (nota >= 0 && nota <= 10) break;
                            }
                            Console.WriteLine("Nota inválida. Debe ser un número entre 0 y 10.\n");
                        }
                        calificaciones.Add(nombreAlumno, nota);
                        while (true)
                        {
                            Console.Write("\n¿Agregar otro alumno? (S/N): ");
                            valor = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(valor) && char.TryParse(valor.Trim(), out char eleccion))
                            {
                                eleccion = char.ToUpperInvariant(eleccion);
                                if (eleccion == 'S')
                                {
                                    continuar = true;
                                    break;
                                }
                                if (eleccion == 'N') 
                                { 
                                    continuar = false;
                                    break;
                                }        
                            }
                            Console.WriteLine("Entrada inválida. Debe ser S/N o s/n.");
                        }
                    } while (continuar);
                    break;
                case 'b':
                    foreach (var calificacion in calificaciones)
                    {
                        sumaNotas += calificacion.Value;
                        cantidadNotas++;
                    }
                    promedioNotas = (cantidadNotas > 0) ? sumaNotas / cantidadNotas : 0;
                    Console.WriteLine($"Promedio de calificaciones del curso: {promedioNotas:F2}");
                    break;
                case 'c':
                    foreach (var calificacion in calificaciones)
                    {
                        if(calificacion.Value > mejorNota)
                        {
                            mejorNota = calificacion.Value;
                            alumnoMejorNota = calificacion.Key;
                        }
                        if (calificacion.Value < peorNota)
                        {
                            peorNota = calificacion.Value;
                            alumnoPeorNota = calificacion.Key;
                        }               
                    }
                    Console.WriteLine($"El alumno {alumnoMejorNota} tiene la mejor nota: {mejorNota:F2}");
                    Console.WriteLine($"El alumno {alumnoPeorNota} tiene la peor nota: {peorNota:F2}");
                    break;
                case 'd':
                    cantidadNumeros++;
                    Console.WriteLine("Saliendo del programa.");
                    break;
            }           
        }
        else
        {
            Console.WriteLine("Debe ingresar la letra a, b, c o d.");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Debes ingresar un caracter.");
        Console.WriteLine();
    }
}
#endregion
Console.WriteLine();
Console.WriteLine();
#region SIMULADOR DE ATENCIÓN EN VENTANILLA
/*
10 - Simulador de atención en ventanilla:
Usar una cola (Queue) para simular la atención de clientes en una ventanilla bancaria.
a. Encolar nombres de clientes.
b. Atender (desencolar) uno por uno hasta que no queden.
c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
Hint: usar Enqueue(), Dequeue() y Count.
*/
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("10) SIMULADOR DE ATENCIÓN EN VENTANILLA");
Console.ResetColor();

Queue<string> colaClientes = new Queue<string>();
string nombreCliente = "";
char opcion;
continuar = true;

Console.WriteLine("Simulador de atención bancaria.");

while (continuar)
{
    Console.WriteLine("\nAcción a realizar:");
    Console.WriteLine("a. Agregar clientes a la cola.");
    Console.WriteLine("b. Atender un cliente.");
    Console.WriteLine("c. Mostrar cantidad de clientes en espera.");
    Console.WriteLine("d. Salir.");
    Console.Write("Opción: ");
    valor = Console.ReadLine();

    if (!char.TryParse(valor, out opcion))
    {
        Console.WriteLine("Entrada inválida. Ingrese una letra válida (a, b, c o d).");
        continue;
    }

    opcion = char.ToLower(opcion);

    switch (opcion)
    {
        case 'a':
            while (true)
            {
                Console.Write("\nIngrese el nombre del cliente a encolar: ");
                nombreCliente = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombreCliente) &&
                    nombreCliente.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    colaClientes.Enqueue(nombreCliente.Trim());
                    Console.WriteLine($"Cliente '{nombreCliente}' agregado a la cola.");

                    Console.Write("¿Desea agregar otro cliente? (S/N): ");
                    string? respuesta = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(respuesta) &&
                        (respuesta.Trim().ToUpper() == "N"))
                        break;
                }
                else
                {
                    Console.WriteLine("Nombre inválido. Solo letras y espacios.\n");
                }
            }
            break;

        case 'b':
            if (colaClientes.Count > 0)
            {
                string clienteAtendido = colaClientes.Dequeue();
                Console.WriteLine($"\nAtendiendo a: {clienteAtendido}");
                Console.WriteLine($"Quedan {colaClientes.Count} clientes en la fila.");
            }
            else
            {
                Console.WriteLine("\nNo hay clientes en la cola para atender.");
            }
            break;

        case 'c':
            Console.WriteLine($"\nClientes en espera: {colaClientes.Count}");
            if (colaClientes.Count > 0)
            {
                Console.WriteLine("Listado de clientes en la cola:");
                foreach (var cliente in colaClientes)
                {
                    Console.WriteLine($"- {cliente}");
                }
            }
            break;

        case 'd':
            continuar = false;
            Console.WriteLine("\nSaliendo del simulador de atención.");
            break;

        default:
            Console.WriteLine("Debe ingresar la letra a, b, c o d.");
            break;
    }
}
#endregion
