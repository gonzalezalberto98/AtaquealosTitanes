using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo Personaje", menuName = "Peronaje")]
public class Personaje : ScriptableObject
{
    public string nombrePersonaje;

    public Sprite artworkPersonaje;
    public Sprite artworkPersonajeCara;
   
    public double ataquePersonaje;
    public double vidaPersonaje;
    public double armaduraPersonaje;

    public string habilidadPasiva;
    public string habilidadActiva;

    public Personaje (Personaje p){
        this.nombrePersonaje = p.nombrePersonaje;
        this.artworkPersonaje = p.artworkPersonaje;
        this.ataquePersonaje = p.ataquePersonaje;
        this.vidaPersonaje = p.vidaPersonaje;
        this.armaduraPersonaje = p.armaduraPersonaje;
        this.habilidadPasiva = p.habilidadPasiva;
        this.habilidadActiva = p.habilidadActiva;
    }
}
