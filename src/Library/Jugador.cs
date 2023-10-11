//se creara el constructor de la clase jugador
//la idea de esta clase es que el jugador pueda elegir su nombre y una Id que sera un codigo de 4 digitos

using System;

namespace Library;

// creo el constructor de la clase jugador
public class Jugador
{
// creo dos propiedades Nombre(string) y Id(int)
//solo le adjudico el set a la propiedad Nombre porque la Id no se puede cambiar
// con los principios de SRP, la clase jugador solo se encarga de crear un jugador con un nombre y una Id
    public string Nombre {get; set;}
    public int Id {get; set;}
// el jugador vera su nombre y su Id
    public Jugador(string nombre, int id)
    {
        Nombre = nombre;
        Id = id;
    }
}