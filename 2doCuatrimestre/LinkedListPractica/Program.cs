using LinkedListPractica;

Lista listaDeNodos = new Lista();

listaDeNodos.AddNodo(10);
listaDeNodos.AddNodo(11);
listaDeNodos.AddNodo(12);

listaDeNodos.PrintNodo();
Console.WriteLine(listaDeNodos.BuscarNodo(29));

listaDeNodos.insertarDespuesDe(10, 29);

listaDeNodos.PrintNodo();
Console.WriteLine(listaDeNodos.BuscarNodo(29));

listaDeNodos.deleteNodo(10);
listaDeNodos.PrintNodo();
Console.WriteLine(listaDeNodos.BuscarNodo(10));