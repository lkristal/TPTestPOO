List<Alumnx> ListaAlumnxs = new List<Alumnx>();
int opcion;
do
{
    Console.Clear();
    Console.WriteLine("1. Ingresar Alumno");
    Console.WriteLine("2. Ver Lista de Alumnos");
    Console.WriteLine("3. Salir");
    opcion = Funciones.IngresarEnteroEnRango("Elija opción: ", 1, 3);
    Console.Clear();
    switch (opcion)
    {
        case 1:
            IngresarAlumno();
            break;
        case 2:
            VerLista();
            break;
    }
} while (opcion != 3);

void IngresarAlumno()
{
    string nom = Funciones.IngresarTexto("Ingrese Nombre ");
    int dni = Funciones.IngresarEntero("Ingrese DNI ");
    string cur = Funciones.IngresarTexto("Ingrese Curso ");
    DateTime fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd) ");
    
    Alumnx UnAlum =  new Alumnx(nom,dni,cur,fn);
     nom = Funciones.IngresarTexto("Ingrese Nombre ");
     dni = Funciones.IngresarEntero("Ingrese DNI ");
     cur = Funciones.IngresarTexto("Ingrese Curso ");
     fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd) ");
    
    Alumnx UnAlum2 =  new Alumnx(nom,dni,cur,fn);
    if (UnAlum.MiEdad() > UnAlum2.MiEdad())
    //Alumnx UnAlumn = new Alumnx();
    //UnAlumn.Curso = cur;
    //UnAlumn.Nombre = nom;
    //UnAlumn.FechaNacimiento = fn;
    //UnAlumn.DNI =  dni;

    ListaAlumnxs.Add(UnAlum);
}

void VerLista(){
foreach(Alumnx item in ListaAlumnxs){
    Console.WriteLine( " Nombre: " +item.Nombre + " Curso: " + item.Curso + " Edad: " + item.MiEdad());
}
Console.ReadLine();
}

