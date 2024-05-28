using ConsoleColecciones;

int[] arrayInts = [5, 6, 7, 2, 19, 100];
var Consulta =
    from entero in arrayInts.Distinct()
    where (entero % 2 == 0 && entero > 4)
    orderby (entero) descending
    select entero;
arrayInts.Append(8);
foreach (var item in Consulta)
{
    Console.WriteLine(item);
}

List<Tablon> Balsa =
[
    new Tablon() { dureza = 8, madera = "pino" },
    new Tablon() { dureza = 7, madera = "caoba" },
    new Tablon() {dureza = 23,madera = "caoba"}
];

var Consulta2 =
    from item in Balsa
    where (item.dureza > 2)
    orderby (item.madera)
    select (item.madera);


var Consulta3 = Balsa.
    Where(x =>x.dureza >2).
    OrderBy(x => x.madera).
    Select(x => x.madera);
foreach (var item in Consulta2)
{
    Console.WriteLine(item);
}
