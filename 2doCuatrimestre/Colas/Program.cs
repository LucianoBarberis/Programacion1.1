using Colas;

Cola cola = new Cola();

int opc = 0;

do
{
    Console.WriteLine("Interaccion con la pila");
    Console.WriteLine("1. Apilar Elemento");
    Console.WriteLine("2. Desapilar Elemento");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Cola:");
    cola.MostrarCola();
    Console.WriteLine("Opcion:");
    opc = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch (opc)
    {
        case 0: Console.WriteLine("Saliendo..."); break;
        case 1: cola.Encolar(); break;
        case 2: cola.DesEncolar(); break;
        default:
            Console.WriteLine("Opcion no valida"); break;
    }

} while (opc != 0);