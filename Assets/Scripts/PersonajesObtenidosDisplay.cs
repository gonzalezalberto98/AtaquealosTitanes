using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PersonajesObtenidosDisplay : MonoBehaviour
{

    public PersonajesObtenidosDisplay personajesObtenidosDisplay;
    public PersonajesObtenidosDisplay personajesEquipo;

    public PersonajeDisplay personajeDisplay;

    public GameObject panel;
    public Personaje personaje;
    public Personaje personajeEquipo;
    public GameObject cartaDisplay; 
    public GameObject cartaDisplayEquipo; 
    public Button boton;
    public Button botonAñadir;
    public Button botonQuitar;
    public TextMeshProUGUI nombrePersonajeText;
    public TextMeshProUGUI nombrePersonajeTextEquipo;
    public Image artworkPersonajeEquipo;
    public Image artworkPersonajeCompleto;
    public Image artworkPersonajeCara;
    
    public Transform zonaVertical;
    public Transform zonaHorizontal;
    public RectTransform zonaPersonajes;

    public float height = 1450.8f;
    public float heightEquipo = 727.3f;
    public float posY = 0f;
    public int cont = 0;

    public TextMeshProUGUI ataqueText;
    public TextMeshProUGUI vidaText;
    public TextMeshProUGUI armaduraText;

    
    public void mostrarPersonajesObentidos()
    {
        crearTarjetas(zonaVertical);
        aumentarTamaño(zonaPersonajes);        

    }

    public void mostrarPersonajesObentidosSinEquipo()
    {
        crearTarjetasSinEquipo(zonaVertical);
        aumentarTamañoSinEquipo(zonaPersonajes);        

    }

    public void mostrarPersonajesEquipo()
    {
        crearTarjetasEquipo(zonaHorizontal);
        //aumentarTamañoSinEquipo(zonaPersonajes);     

    }

    public void setPersonajeObtenido(Personaje p){
        this.personaje = p;
        if (nombrePersonajeText != null)
            {this.nombrePersonajeText.text = p.nombrePersonaje;}
        if (artworkPersonajeCompleto!= null)
            {this.artworkPersonajeCompleto.sprite = p.artworkPersonaje;}
        if (artworkPersonajeCara!= null)
            {this.artworkPersonajeCara.sprite = p.artworkPersonajeCara;}
    }

    public void setPersonajeEquipo(Personaje p){
        this.personajeEquipo = p;
        if (nombrePersonajeTextEquipo != null)
            {this.nombrePersonajeTextEquipo.text = p.nombrePersonaje;}
        if (artworkPersonajeEquipo!= null)
            {this.artworkPersonajeEquipo.sprite = p.artworkPersonaje;}
    }      

    public void printrPersonajesObtenidos()
    {
        foreach (Personaje p in GameManager.personajesObtenidos){

                print(p.nombrePersonaje);
            
            }
    }

    public void crearTarjetas(Transform newParent)
    {
        foreach (Personaje p in GameManager.personajesObtenidos){
                personajesObtenidosDisplay.setPersonajeObtenido(p);
                personajeDisplay.setPersonaje(p);
                var clone = Instantiate(cartaDisplay);
                clone.transform.SetParent(newParent.transform);
                clone.SetActive(true);                
        }        
    }

    public void crearTarjetasSinEquipo(Transform newParent)
    {
        foreach (Personaje p in GameManager.personajesObtenidos){
            if (GameManager.equipo.Contains(p) == false){           
                personajesObtenidosDisplay.setPersonajeObtenido(p);                
                var clone = Instantiate(cartaDisplay);
                clone.transform.SetParent(newParent.transform);
                clone.SetActive(true);
            }                               
        }       
    }

    public void crearTarjetasEquipo(Transform newParent)
    {
        foreach (Personaje p in GameManager.equipo){                      
                personajesEquipo.setPersonajeEquipo(p);                
                var clone = Instantiate(cartaDisplayEquipo);
                clone.transform.SetParent(newParent.transform);
                clone.SetActive(true);
                                         
        }    
    }


    public void aumentarTamaño(RectTransform tr){
        foreach (Personaje p in GameManager.personajesObtenidos){
                cont += 1;
                if (cont >4) {
                    height += 433.1963f;
                    posY += 216.59f;
                }
        }
        
        tr.transform.position = new Vector3(540,-posY,0);
        tr.sizeDelta = new Vector2(984.4781f, height);
        cont = 0;
    }

    public void aumentarTamañoSinEquipo(RectTransform tr){
        foreach (Personaje p in GameManager.personajesObtenidos){
                cont += 1;
                if (cont >3) {
                    heightEquipo += 250.0f;
                    posY += 216.59f;
                }
        }
        
        tr.transform.position = new Vector3(540,-posY,0);
        tr.sizeDelta = new Vector2(984.4781f, heightEquipo);
        cont = 0;
    }


    public void verInformacionPersonaje(GameObject popup){
                
        if (popup != null)
        {
            popup.SetActive(true);
        }
    }

    public void asignarPersonajePopup(PersonajesObtenidosDisplay personajeInfo){

            personajeDisplay.setPersonaje(personajeInfo.personaje);
    }

    public void añadirAEquipo(PersonajesObtenidosDisplay personajeInfo){
        cont = 0;
        foreach (Personaje p in GameManager.equipo){
            cont+=1;
        }
        if (cont >= 3){
            print("Equipo lleno");
        }
        else{
        GameManager.equipo.Add(personajeInfo.personaje);}
        

        SceneManager.LoadScene("EditarEquipoScene");
    }
    
    public void quitarDeEquipo(PersonajesObtenidosDisplay personajeInfo){
        cont=0;
        foreach (Personaje p in GameManager.equipo){
            if (p.nombrePersonaje == personajeInfo.personajeEquipo.nombrePersonaje){
                print(p.nombrePersonaje);
                GameManager.equipo.RemoveAt(cont);
                SceneManager.LoadScene("EditarEquipoScene");
                return;
            }
            cont += 1;    
        }
        
    }

    public void mostrarStatsEquipo(){
        double ataque = 0;
        double vida = 0;
        double armadura = 0;
        foreach (Personaje p in GameManager.equipo){
            ataque += p.ataquePersonaje;
            vida += p.vidaPersonaje;
            armadura += p.armaduraPersonaje;
        }
        this.ataqueText.text = ataque.ToString();
        this.vidaText.text = vida.ToString();
        this.armaduraText.text = armadura.ToString();
    }
    
}
