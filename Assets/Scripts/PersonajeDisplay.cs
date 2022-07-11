using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PersonajeDisplay : MonoBehaviour
{

    public Personaje personaje;

    public GameObject cartaDisplay;

    public TextMeshProUGUI nombrePersonajeText;

    public Image artworkPersonajeCarta;
    
   

    public TextMeshProUGUI ataquePersonajeText;
    public TextMeshProUGUI vidaPersonajeText;
    public TextMeshProUGUI armaduraPersonajeText;

    public TextMeshProUGUI habilidadPasivaPersonajeText;
    public TextMeshProUGUI habilidadActivaPersonajeText;


    public void setPersonaje(Personaje personaje){
        this.personaje = personaje;
        nombrePersonajeText.text = personaje.nombrePersonaje;

        artworkPersonajeCarta.sprite = personaje.artworkPersonaje;

        ataquePersonajeText.text = personaje.ataquePersonaje.ToString();
        vidaPersonajeText.text = personaje.vidaPersonaje.ToString();
        armaduraPersonajeText.text = personaje.armaduraPersonaje.ToString();

        habilidadPasivaPersonajeText.text = personaje.habilidadPasiva;
        habilidadActivaPersonajeText.text = personaje.habilidadActiva;
    }

    public void mostrar(){
        cartaDisplay.SetActive(true);
    }

    public void ocultar(){
        cartaDisplay.SetActive(false);
    }

}
