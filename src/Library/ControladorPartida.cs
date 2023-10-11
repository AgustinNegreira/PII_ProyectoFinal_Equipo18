// creamos un constructor para la clase controlador de partida

using System;

namespace Library;

public class ControladorPartida
{
    // creo dos metodos FinalizarPartida, Iniciarpartida y dos propiedades ContadorJugador1(int), ContadorJugador2(int)
    public void FinalizarPartida()
    {}
    public void Iniciarpartidaa()
    {}
    // segun los principios de SRP, la clase controlador de partida solo se encarga de iniciar y finalizar la partida
    public string ContadorJugador1 {get; set;}

    public string ContadorJugador2 {get; set;}
    // contador de jugador 1 y 2  se encarga de llevar el control de los turnos de cada jugador
}