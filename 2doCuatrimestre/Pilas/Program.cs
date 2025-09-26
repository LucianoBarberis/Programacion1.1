using Pilas;

Pila listaPila = new Pila();
int opc = 0;

do
{
    Console.WriteLine("Interaccion con la pila");
    Console.WriteLine("1. Apilar Elemento");
    Console.WriteLine("2. Desapilar Elemento");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Pila:");
    listaPila.MostrarPila();
    Console.WriteLine("Opcion:");
    opc = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opc)
    {
        case 0: Console.WriteLine("Saliendo...");break;
        case 1: apilarElemento();break;
        case 2: listaPila.DesApilar();break;
        default: 
            Console.WriteLine("Opcion no valida");break;
    }

}while (opc != 0);

void apilarElemento()
{
    Console.WriteLine("Elemento a apilar: ");
    listaPila.Apilar(Convert.ToInt32(Console.ReadLine()));
    Console.Clear();
}