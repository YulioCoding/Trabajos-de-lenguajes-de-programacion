using System;
using System.Collections.Generic;
using System.Linq;

// ============================================================
// CLASE BASE ABSTRACTA: Material
// ============================================================

abstract class Material
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Anno { get; set; }

    public Material(string titulo, string autor, int anno)
    {
        Titulo = titulo;
        Autor = autor;
        Anno = anno;
    }

    public abstract void MostrarInfo();
}

// ============================================================
// CLASE DERIVADA: Libro
// ============================================================

class Libro : Material
{
    public string Genero { get; set; }
    public int NumPaginas { get; set; }
    public bool EstaDisponible { get; set; } = true;

    public Libro(string titulo, string autor, int anno, string genero, int numPaginas)
        : base(titulo, autor, anno)
    {
        Genero = genero;
        NumPaginas = numPaginas;
    }

    public override void MostrarInfo()
    {
        string estado = EstaDisponible ? "Disponible" : "Prestado";

        Console.WriteLine($"[LIBRO] {Titulo,-25} | Autor: {Autor,-20} | Año: {Anno} | Genero: {Genero,-10} | Paginas: {NumPaginas} | Estado: {estado}");
    }
}

// ============================================================
// CLASE DERIVADA: Revista
// ============================================================

class Revista : Material
{
    public int Edicion { get; set; }
    public string Tematica { get; set; }

    public Revista(string titulo, string autor, int anno, int edicion, string tematica)
        : base(titulo, autor, anno)
    {
        Edicion = edicion;
        Tematica = tematica;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"[REVISTA] {Titulo,-25} | Autor: {Autor,-20} | Año: {Anno} | Edicion: {Edicion} | Tematica: {Tematica}");
    }
}

// ============================================================
// CLASE: Biblioteca
// ============================================================

class Biblioteca
{
    private List<Material> catalogo = new List<Material>();

    public void Agregar(Material m)
    {
        catalogo.Add(m);
    }

    public Material BuscarPorTitulo(string titulo)
    {
        return catalogo.FirstOrDefault(m => m.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public void ListarDisponibles()
    {
        Console.WriteLine("\n=== LIBROS DISPONIBLES ===");

        var disponibles = catalogo.OfType<Libro>().Where(l => l.EstaDisponible).ToList();

        if (disponibles.Count == 0)
            Console.WriteLine("No hay libros disponibles");
        else
            disponibles.ForEach(l => l.MostrarInfo());
    }

    public void ListarTodo()
    {
        Console.WriteLine("\n=== CATALOGO COMPLETO ===");
        catalogo.ForEach(m => m.MostrarInfo());
    }

    public void PrestarLibro(string titulo)
    {
        var libro = catalogo.OfType<Libro>()
            .FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

        if (libro == null)
            throw new Exception("El libro no existe.");

        if (!libro.EstaDisponible)
            throw new Exception("El libro ya está prestado.");

        libro.EstaDisponible = false;

        Console.WriteLine("Libro prestado correctamente.");
    }

    public void DevolverLibro(string titulo)
    {
        var libro = catalogo.OfType<Libro>()
            .FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

        if (libro == null)
            throw new Exception("El libro no existe.");

        if (libro.EstaDisponible)
            throw new Exception("El libro no estaba prestado.");

        libro.EstaDisponible = true;

        Console.WriteLine("Libro devuelto correctamente.");
    }
}

// ============================================================
// PROGRAMA PRINCIPAL
// ============================================================

class Program
{
    static void Main(string[] args)
    {
        Biblioteca bib = new Biblioteca();

        // Libros
        bib.Agregar(new Libro("Cien Anios de Soledad", "Garcia Marquez", 1967, "Novela", 417));
        bib.Agregar(new Libro("El Principito", "Saint-Exupery", 1943, "Infantil", 96));
        bib.Agregar(new Libro("1984", "George Orwell", 1949, "Distopia", 328));

        // Revistas
        bib.Agregar(new Revista("National Geographic", "Varios", 2024, 312, "Ciencia"));
        bib.Agregar(new Revista("Scientific American", "Varios", 2023, 289, "Tecnologia"));

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n========= BIBLIOTECA =========");
            Console.WriteLine("1. Ver catalogo");
            Console.WriteLine("2. Ver libros disponibles");
            Console.WriteLine("3. Buscar libro");
            Console.WriteLine("4. Prestar libro");
            Console.WriteLine("5. Devolver libro");
            Console.WriteLine("6. Salir");

            Console.Write("Seleccione una opcion: ");
            string opcion = Console.ReadLine();

            try
            {
                switch (opcion)
                {
                    case "1":
                        bib.ListarTodo();
                        break;

                    case "2":
                        bib.ListarDisponibles();
                        break;

                    case "3":

                        Console.Write("Ingrese el titulo del libro: ");
                        string tituloBuscar = Console.ReadLine();

                        var material = bib.BuscarPorTitulo(tituloBuscar);

                        if (material == null)
                            Console.WriteLine("No se encontro el libro.");
                        else
                            material.MostrarInfo();

                        break;

                    case "4":

                        Console.Write("Ingrese el titulo del libro a prestar: ");
                        string tituloPrestar = Console.ReadLine();

                        bib.PrestarLibro(tituloPrestar);

                        break;

                    case "5":

                        Console.Write("Ingrese el titulo del libro a devolver: ");
                        string tituloDevolver = Console.ReadLine();

                        bib.DevolverLibro(tituloDevolver);

                        break;

                    case "6":

                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        Console.WriteLine("Programa finalizado.");
    }
}
