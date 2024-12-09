using Godot;
using System;

class Hola {
	public string s;
	public int c;
}

public partial class Label : Godot.Label
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ListaEnlazada<int> lista = new ListaEnlazada<int>();
        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);

        GD.Print("Lista antes de actualizar:");
        lista.Iterar((int a) => GD.Print(a)); // Muestra 1, 2, 3

        // Actualizar el valor 2 por 5
        lista.Actualizar(2, 5);

        GD.Print("Lista después de actualizar 2 a 5:");
        lista.Iterar((int a) => GD.Print(a)); // Muestra 1, 5, 3

        // Eliminar el valor 3
        lista.Eliminar(3);

        GD.Print("Lista después de eliminar 3:");
        lista.Iterar((int a) => GD.Print(a)); // Muestra 1, 5

        // Intentar eliminar un valor que no está en la lista
        lista.Eliminar(4);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
