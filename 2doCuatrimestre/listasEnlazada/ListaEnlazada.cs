public class ListaEnlazada
{
    private Nodo? cabeza;

    // Agrega un nodo al final
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);

        // Verificamos si la lista está vacía
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Muestra todos los nodos
    public void Mostrar()
    {
        Nodo? actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }

    // Busca un valor
    public bool Buscar(int valor)
    {
        Nodo? actual = cabeza;
        while (actual != null)
        {
            if (actual.Valor == valor)
                return true;
            actual = actual.Siguiente;
        }
        return false;
    }

    // Elimina un nodo por valor
    public void Eliminar(int valor)
    {
        if (cabeza == null) return;

        if (cabeza.Valor == valor)
        {
            cabeza = cabeza.Siguiente;
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Valor != valor)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
        }
    }

    // Inserta un nodo después de un valor específico
    public void InsertarDespuesDe(int valorExistente, int nuevoValor)
    {
        Nodo? actual = cabeza;
        while (actual != null && actual.Valor != valorExistente)
        {
            actual = actual.Siguiente;
        }

        if (actual != null)
        {
            Nodo nuevo = new Nodo(nuevoValor);
            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }
}