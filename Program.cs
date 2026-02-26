// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//crear instancias
var lista_deportes = new List<Deportes>();
lista_deportes.Add(new Deportes(){Id=1, Nombre="futbol", Fecha= DateTime.Now, Activo= true});
lista_deportes.Add(new Deportes(){Id=2, Nombre="voley", Fecha= DateTime.Now, Activo= true});
lista_deportes.Add(new Deportes(){Id=3, Nombre="Basquet", Fecha= DateTime.Now, Activo= false});

var lista_equipos = new List<Equipos>();
lista_equipos.Add(new Equipos(){Id=1, Nombre="Los Pibes", Fecha= DateTime.Now, Activo= true});
lista_equipos.Add(new Equipos(){Id=2, Nombre="Boca Juniors", Fecha= DateTime.Now, Activo= false});
lista_equipos.Add(new Equipos(){Id=3, Nombre="Las Pibas", Fecha= DateTime.Now, Activo= false});
lista_equipos.Add(new Equipos(){Id=4, Nombre="Rivers", Fecha= DateTime.Now, Activo= true});

var lista_deportes_equipos = new List<Deportes_Equipos>();
lista_deportes_equipos.Add(new Deportes_Equipos(){Id=1, Deporte= 1, Equipo=1});
lista_deportes_equipos.Add(new Deportes_Equipos(){Id=2, Deporte= 1, Equipo=2});
lista_deportes_equipos.Add(new Deportes_Equipos(){Id=3, Deporte= 2, Equipo=3});
lista_deportes_equipos.Add(new Deportes_Equipos(){Id=4, Deporte= 2, Equipo=4});

var lista_entrenadores = new List<Entrenadores>();
lista_entrenadores.Add(new Entrenadores(){Id=1, Nombre= "Juan Valdez", Cedula="123", Fecha= DateTime.Now, Equipo=1, Activo= true});
lista_entrenadores.Add(new Entrenadores(){Id=2, Nombre= "Alberto Rojas", Cedula="456", Fecha= DateTime.Now, Equipo=2, Activo= false});

var lista_deportistas = new List<Deportistas>();
lista_deportistas.Add(new Deportistas(){Id=1, Nombre= "Carlos Alcaraz", Cedula="678", Fecha= DateTime.Now, Equipo=1,Sueldo= 123000000.0m,Activo= true});
lista_deportistas.Add(new Deportistas(){Id=2, Nombre= "Kyliam Mbappe", Cedula="901", Fecha= DateTime.Now, Equipo=2,Sueldo=300000000.0m, Activo= true});

var lista_implementos = new List<Implementos>();
lista_implementos.Add(new Implementos(){Id=1, Nombre="Balon", Deporte=1, Activo= true});
lista_implementos.Add(new Implementos(){Id=2, Nombre="red", Deporte=2, Activo= true});
//calculos
//muestra el nombre del deportista con mejor sueldo
var mejor_pagado = lista_deportistas.MaxBy(x =>x.Sueldo);
Console.WriteLine("El deportista mejor pagado es: "+mejor_pagado.Nombre);

//muestra los equipos que estan activos
var equiposfutbol = lista_deportes.Where(x=>x.Activo);
Console.WriteLine("Los deportes activos son: ");
foreach (var deporte in equiposfutbol )
{
    Console.WriteLine("- " + deporte.Nombre);
};


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

public class Personas
{
    public int Id { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }
}

public class Entrenadores : Personas
{
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Deportistas: Personas
{
    public decimal Sueldo { get; set; }
    public int Equipo { get; set; }

    public Equipos? _Equipo { get; set; }
}

public class Implementos
{
    public int Id { get; set; }
    public String? Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public bool Activo { get; set; }
    public int Deporte { get; set; }

    public Deportes? _Deporte{get; set;}
}
    public int Deporte { get; set; }

    public Deportes? _Deporte{get; set;}

}
