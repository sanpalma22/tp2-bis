int opcion;
do
{
    menu();
    opcion = IngresarEntero("Ingresa la opción del menú que desea realizar");
    switch (opcion)
    {
        case 1:
        Boxeador boxeador1= registrarBoxeador();
        break;
        case 2:
        Boxeador boxeador2= registrarBoxeador();
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
string IngresarTexto(string v)
{
    string text;
    Console.WriteLine(v);
    text=Console.ReadLine();
    return text;
}
Boxeador registrarBoxeador()
{
    string nom=IngresarTexto("Ingrese el nombre del boxeador");
    string pais=IngresarTexto("Ingrese el país del boxeador" );
    int peso=IngresarEntero("Ingrese el peso en KG del boxeador");
    int pg=IngresarEntero("Ingrese la potencia de los golpes entre 1 y 100, del boxeador");
    int vp=IngresarEntero("Ingrese la velocidad de los pies entre 1 y 100, del boxeador");
    Boxeador unBoxeador=new Boxeador(nom,pais,peso,pg,vp);
    Console.WriteLine("Se ha creado el boxeador "+nom);
    return unBoxeador;
}