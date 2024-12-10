public abstract class Lista<T> {
    public abstract Nodo<T> Head { get; set; }

    // Logica para CRUD
    // Agregar
    // etc
}

public class EsquemaCliente {
    public string cedula;
    public string nombre;
}

public class ModeloCliente : Lista<EsquemaCliente> {
    public override Nodo<EsquemaCliente> Head {get; set; }
}