//se creará un objeto de tipo nave y se le asignará un nombre y una imagenpublic class Nave 
using System;

namespace Library;

//creamos un constructor para la clase nave
public class ControladorNaves
{
    // creo dos metodos RegistrasNaves, PosicionNaves y voy a tener una propiedad ConocerPosicionNaves
    public void RegistrarNaves()
    {}
    //segun el principio de SRP, la clase controlador de naves solo se encarga de registrar 
    //las naves y de conocer la posicion de las naves
    public void PosicionNaves()
    {}
    // ConocerPosicionNaves se encarga de conocer la posicion de las naves, segun el principio de SRP
    // la clase controlador de naves solo se encarga de registrar las naves y de conocer la posicion de las naves
    public string ConocerPosicionNaves {get; set;}
    
}
