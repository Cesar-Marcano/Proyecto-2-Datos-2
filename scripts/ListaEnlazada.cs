using Godot;

public class ListaEnlazada<T>
{
    public Nodo<T> Head { get; private set; }

    public void Agregar(T valor)
    {
        var nuevoNodo = new Nodo<T>(valor);
        if (Head == null)
        {
            Head = nuevoNodo;
        }
        else
        {
            Nodo<T> actual = Head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public delegate void Accion(T valor);
    public void Iterar(Accion callback)
    {
        Nodo<T> actual = Head;

        while (actual != null)
        {
            callback(actual.Valor);
            actual = actual.Siguiente;
        }
    }

    public delegate bool Predicate<in X>(X obj);
    public T Obtener(Predicate<T> predicate) {
        if (Head == null) {
            return default;
        }
        
        Nodo<T> actual = Head;
        while (actual != null) {
            if (predicate(actual.Valor)) {
                return actual.Valor;
            }
            actual = actual.Siguiente;
        }
        return default;
    }

    public void Actualizar(T valor, T nuevo)
    {
        if (Head == null)
        {
            return;
        }

        Nodo<T> actual = Head;
        while (actual != null)
        {
            if (actual.Valor.Equals(valor))
            {
                actual.Valor = nuevo;
                return;
            }
            actual = actual.Siguiente;
        }
    }

    public void Eliminar(T valor)
    {
        if (Head == null)
        {
            return;
        }

        if (Head.Valor.Equals(valor))
        {
            Head = Head.Siguiente;
            return;
        }

        Nodo<T> actual = Head;
        while (actual.Siguiente != null)
        {
            if (actual.Siguiente.Valor.Equals(valor))
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                return;
            }
            actual = actual.Siguiente;
        }
    }
}