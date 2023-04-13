int opcion;
do
{
    menu();
    opcion = IngresarEntero("Ingresa la opción del menú que desea realizar");
    switch (opcion)
    {
        case 1:
            Boxeador boxeador1 = registrarBoxeador();
            break;
        case 2:
            Boxeador boxeador2 = registrarBoxeador();
            break;
        case 3:
            pelea(boxeador1, boxeador2);
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
    
}
