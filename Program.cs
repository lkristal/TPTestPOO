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
    string nom = Funciones.IngresarTexto("Ingrese Nombre");
    int dni = Funciones.IngresarEntero("Ingrese DNI ");
    string cur = Funciones.IngresarTexto("Ingrese Curso");
    DateTime fn = Funciones.IngresarFecha("Ingrese Fecha de Nacimiento");

}

void VerLista(){
    

}

