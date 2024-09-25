// See https://aka.ms/new-console-template for more information
using Linq;

Console.WriteLine("Hello, World!");

Libro[] libros = new Libro[]
{
    new Libro("El Psicoanalista","John Kazetnvach"),
    new Libro("Martin Fierro","Jose Hernandez"),
    new Libro("Millennium I","Stieg Larsson"),
    new Libro("Millennium II","Stieg Larsson"),
};


// select autor from libro where titulo like 'Millennium%'
//Sintaxis de consulta
IEnumerable<string> autorEnumerable = from libro
                                      in libros
                                      where libro.Titulo.Contains("Millennium")
                                      select libro.Autor;

//Sintaxis de funcion
IEnumerable<string> autorEnumerable2 = libros.Where(l => l.Titulo.Contains("Millennium")).Select(l => l.Autor);

foreach (string autor in autorEnumerable)
{
    Console.WriteLine(autor);
}

Console.WriteLine("Consulta de Funcion");
foreach (string autor in autorEnumerable2)
{
    Console.WriteLine(autor);
}
Console.ReadLine();

//Agrupar
IEnumerable<IGrouping<string, Libro>> librosAgrupados = libros.GroupBy(l => l.Autor);

foreach(var agrupados in librosAgrupados)
{
    foreach(var agrupado in agrupados)
    {
        Console.WriteLine(agrupado.Autor);
    }
}

IEnumerable<Libro> filtroLibros = libros.Filtro(l => l.Autor == "Stieg Larsson");
if(filtroLibros != null && filtroLibros.ToList().Count > 0)
{
    Console.WriteLine($"Aplicando filtro: {filtroLibros.First().Titulo}");
}
