// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//clases
public class Deportes
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }


    public List<Deportes_Equipos>? Deportes_Equipos { get; set; }
    public List<Implementos>? Implementos { get; set; }
}

public class Deportes_Equipos
{
    public int Id { get; set; }
    public int Deporte { get; set; }
    public int Equipo { get; set; }


    public Deportes? _Deporte { get; set; }
    public Equipos? _Equipo { get; set; }
}

public class Equipos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }


    public List<Deportes_Equipos>? Deportes_Equipos { get; set; }
    public List<Deportistas>? Deportistas { get; set; }
    public List<Entrenadores>? Entrenadores { get; set; }
}

public class Persoas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }
}

public class Entrenadores : Persoas
{
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Deportistas: Persoas
{
    public decimal Sueldo { get; set; }
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Implementos
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }
    public int Deporte { get; set; }

    public Deportes? _Deporte{get; set;}
}