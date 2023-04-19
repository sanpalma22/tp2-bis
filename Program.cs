Boxeador boxeador1 = null;
Boxeador boxeador2 = null;
int opcion;
do
{
    menu();
    opcion = IngresarEntero("Ingresa la opción del menú que desea realizar");
    Console.Clear();
    switch (opcion)
    {
        case 1:
            boxeador1 = registrarBoxeador();
            break;
        case 2:
            boxeador2 = registrarBoxeador();
            break;
        case 3:
            if (boxeador1 != null && boxeador2 != null) {
                pelea(boxeador1, boxeador2);
                Console.ReadKey();
            }
            else Console.WriteLine("ERROR: Alguno de los boxeadores no están ingresados");
            break;
        case 4:
            break;
        default:
            Console.WriteLine("Opción ingresada inexistente. Intente de nuevo");
            break;
    }
} while (opcion != 4);

void menu()
{
    Console.WriteLine("1. Cargar Datos Boxeador 1");
    Console.WriteLine("2. Cargar Datos Boxeador 2");
    Console.WriteLine("3. PELEA!");
    Console.WriteLine("4. Salir");
}
int IngresarEntero(string v)
{
    int num;
    Console.WriteLine(v);
    num = int.Parse(Console.ReadLine());
    return num;
}
int IngresarEnteroRango(string v, int min, int max)
{
    int num;
    do
    {
        num = IngresarEntero(v);
        if (num < min || num > max) Console.WriteLine("Error: el número debe ser entre {0} y {1}", min, max);
    } while (num < min || num > max);
    return num;
}
string IngresarTexto(string v)
{
    string text;
    Console.WriteLine(v);
    text = Console.ReadLine();
    return text;
}
Boxeador registrarBoxeador()
{
    string nom = IngresarTexto("Ingrese el nombre del boxeador").ToUpper();
    string pais = IngresarTexto("Ingrese el país del boxeador").ToUpper();
    int peso = IngresarEntero("Ingrese el peso en KG del boxeador");
    int pg = IngresarEnteroRango("Ingrese la potencia de los golpes entre 1 y 100, del boxeador", 1, 100);
    int vp = IngresarEnteroRango("Ingrese la velocidad de los pies entre 1 y 100, del boxeador", 1, 100);
    Boxeador unBoxeador = new Boxeador(nom, pais, peso, pg, vp);
    Console.WriteLine("Se ha creado el boxeador " + nom);
    return unBoxeador;
}
void pelea(Boxeador boxeador1, Boxeador boxeador2)
{
    if (boxeador1.ObtenerSkill() > boxeador2.ObtenerSkill()) veredicto(boxeador1, boxeador2);
    else veredicto(boxeador2, boxeador1);
}
void veredicto(Boxeador ganador, Boxeador perdedor)
{
    if (ganador.ObtenerSkill() >= perdedor.ObtenerSkill() + 30) Console.WriteLine("Ganó {0} por KO", ganador.Nombre);
    else if (ganador.ObtenerSkill() >= perdedor.ObtenerSkill() + 10) Console.WriteLine("Ganó {0} por puntos en fallo unánime", ganador.Nombre);
    else Console.WriteLine("Ganó {0} por puntos en fallo dividido", ganador.Nombre);
}