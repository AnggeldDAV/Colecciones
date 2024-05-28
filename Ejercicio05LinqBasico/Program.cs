//Primer Array Ints

using Ejercicio05LinqBasico;

int[] arrayDeEnteros = [1, 4, 5, 6, 1, 2, 6];

//1.Mostrar aquellos que son mayores que 2
Console.WriteLine("Ejercicio1\n");
var ConMayores2 = arrayDeEnteros.Where(x => x > 2).Select(x => x);
foreach (var entero in ConMayores2)
{
    Console.WriteLine(entero);
}

//2.Mostrar aquellos que son menores que 5
Console.WriteLine("Ejercicio2\n");
var ConMenores5 = arrayDeEnteros.Where(x => x < 5).Select(x => x);
foreach (var entero in ConMenores5)
{
    Console.WriteLine(entero);
}

//3.Mostrar aquellos que son mayores que 2 pero ordenados de mayor a menor.
Console.WriteLine("Ejercicio3\n");
var ConMayor2OrdMayor = arrayDeEnteros.Where(x => x > 2).OrderByDescending(x => x).Select(x => x);
foreach (var entero in ConMayor2OrdMayor)
{
    Console.WriteLine(entero);
}

//4.Mostrar aquellos números que son únicos.
Console.WriteLine("Ejercicio4\n");
var ConUnicos = arrayDeEnteros.Distinct().Select(x => x);
foreach (var entero in ConUnicos)
{
    Console.WriteLine(entero);
}

//5.Mostrar los números pares.
Console.WriteLine("Ejercicio5\n");
var ConPares = arrayDeEnteros.Where(x => x % 2 == 0).Select(x => x);
foreach (var entero in ConPares)
{
    Console.WriteLine(entero);
}

//6.Mostrar los números pares mayores de 4 ordenados de menor a mayor
Console.WriteLine("Ejercicio6\n");
var ConParMay4Ord = arrayDeEnteros.Where(x => x % 2 == 0 && x > 4).OrderBy(x => x).Select(x => x);

foreach (var entero in ConParMay4Ord)
{
    Console.WriteLine(entero);
}

//Segundo Array Cadenas
string[] arrayDeCadenas = ["Alberto", "Jacinto", "Adrian", "Merche", "Eva", "Maria"];

//1. Ordenar la lista alfabeticamente.
Console.WriteLine("Ejercicio1\n");
var ConListAlf = arrayDeCadenas.OrderBy(x => x).Select(x => x);
foreach (var nombre in ConListAlf)
{
    Console.WriteLine(nombre);
}

//2. Ordenar la lista alfabeticamente al reves.
Console.WriteLine("Ejercicio2\n");
var ConListAlfReves = arrayDeCadenas.OrderByDescending(x => x).Select(x => x);
foreach (var nombre in ConListAlfReves)
{
    Console.WriteLine(nombre);
}

//3. Ordenar la lista por el número de caracteres de cada palabra.
Console.WriteLine("Ejercicio3\n");
var ConListOrdNumeroCaracteres = arrayDeCadenas.OrderBy(x => x.Length).Select(x => x);
foreach (var nombre in ConListOrdNumeroCaracteres)
{
    Console.WriteLine(nombre);
}

//4. Seleccionar aquellas cadenas que comiencen por a y terminen por o u n.
Console.WriteLine("Ejercicio4\n");
var ConListComATermON =
    arrayDeCadenas.Where(x => x.StartsWith("A") && (x.EndsWith("o") || x.EndsWith("n"))).Select(x => x);
foreach (var nombre in ConListComATermON)
{
    Console.WriteLine(nombre);
}

//5. Seleccionar aquellas cadenas cuya longitud sea mas de 4 caracteres
Console.WriteLine("Ejercicio5\n");
var ConListLongCarMayor4 =
    arrayDeCadenas.Where(x => x.Length > 4).Select(x => x);
foreach (var nombre in ConListLongCarMayor4)
{
    Console.WriteLine(nombre);
}

//Tercer Array Personas

Persona Manolo = new Persona(){Nombre = "Manolo",FechaNacimiento = (new DateOnly(1978,06,26)),Sueldo = 2400};
Persona Ana = new Persona(){Nombre = "Ana",FechaNacimiento = (new DateOnly(1982,07,27)),Sueldo = 3200};
Persona Felipe = new Persona(){Nombre = "Felipe",FechaNacimiento = (new DateOnly(1995,06,29)),Sueldo = 2100};
Persona Ambrosio = new Persona(){Nombre = "Ambrosio",FechaNacimiento = (new DateOnly(1994,06,28)),Sueldo = 2000};
Persona Raquel = new Persona(){Nombre = "Raquel",FechaNacimiento = (new DateOnly(2000,05,25)),Sueldo = 1500};
Persona Luisa = new Persona(){Nombre = "Luisa",FechaNacimiento = (new DateOnly(2002,02,20)),Sueldo = 1600};
Persona Ernesto = new Persona(){Nombre = "Ernesto",FechaNacimiento = (new DateOnly(2010,01,10)),Sueldo = 600};

List<Persona>Personas = [Manolo,Ana,Felipe,Ambrosio,Raquel,Luisa,Ernesto];

//1.Ordenar la colección por sueldo de menos a más.
Console.WriteLine("Ejercicio1\n");
var ConPersOrdSueldo = Personas.OrderBy(x => x.Sueldo).Select(x => x);
foreach (var Persona in ConPersOrdSueldo)
{
    Console.WriteLine(Persona);
}
//2. Seleccionar aquellos que sean mayores de edad.
Console.WriteLine("Ejercicio2\n");
var AnhoActual = DateOnly.FromDateTime(DateTime.Now).Year;
var ConPersMayoresEdad= Personas.Where(x=> x.Ed).Select(x => x);
foreach (var Persona in ConPersOrdSueldo)
{
    Console.WriteLine(Persona);
}
//3. Ordenar por edad de más joven a menos joven.
Console.WriteLine("Ejercicio3\n");

//4. Seleccionar aquellos cuyo nombre comienza por A o por E
Console.WriteLine("Ejercicio4\n");

//5. Saber cual es el sueldo total.
Console.WriteLine("Ejercicio5\n");

//6. Saber cual es el sueldo medio.
Console.WriteLine("Ejercicio6\n");

//7. Ordenar por sueldo, para aquellos mayores de edad que tienen un sueldo par.
Console.WriteLine("Ejercicio7\n");
