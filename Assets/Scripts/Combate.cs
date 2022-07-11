using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combate : MonoBehaviour
{
    public Image vidaEquipo;
    public Image vidaTitan;

    public GameObject popupExito;
    public GameObject popupFallo;

    public Image personajeEquipo;
    public Transform zonaHorizontal;

    public float vidaActualEquipo;
    public float vidaMaximaEquipo;

    public float vidaActualTitan;
    public float vidaMaximaTitan;

    public double dañoEquipo = 0;
    public double dañoTitan;

    void Start(){
        foreach (Personaje p in GameManager.equipo){
            dañoEquipo += p.ataquePersonaje;
            vidaActualEquipo += (float)p.vidaPersonaje;
            vidaMaximaEquipo += (float)p.vidaPersonaje;
            var clone = Instantiate(personajeEquipo);
            clone.transform.SetParent(zonaHorizontal.transform);
            clone.sprite = p.artworkPersonajeCara;     
            clone.gameObject.SetActive(true);
        }

        InvokeRepeating("dañarEquipo", 2.0f, 2.0f);
    }

    void Update()
    {
        vidaEquipo.fillAmount= vidaActualEquipo / vidaMaximaEquipo;
        vidaTitan.fillAmount= vidaActualTitan / vidaMaximaTitan;
    }

    public void dañarTitan(){
        if (vidaActualTitan >= 1.0){
            vidaActualTitan -= (float)dañoEquipo;
        }
        else{
            popupExito.SetActive(true);
            GameManager.insignias += 1;
            GameManager.dinero += 1500;
        }
    }

    public void dañarEquipo(){
        if (vidaActualEquipo >= 1.0){
            vidaActualEquipo-= (float)dañoTitan;
        }
        else{
            if(vidaActualTitan > 0){
            popupFallo.SetActive(true);
            }
        }
    }
}
