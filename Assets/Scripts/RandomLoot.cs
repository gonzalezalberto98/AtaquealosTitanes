using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomLoot : MonoBehaviour
{
    public List<Personaje> personajes = new List<Personaje>();

    public Popup popup;

    public PersonajeDisplay personajeDisplay;
    
    void Start()
    {
        
    }
    public void obtenerPersonaje()
    {
        
        int randomNumber;

        

        if (GameManager.insignias > 0)
        {         
                           
            if (GameManager.contVisitados == GameManager.numPersonajes){
                personajeDisplay.ocultar();
                popup.OpenPanel("No quedan personajes obtenibles");
            }
            else{

            do{
            randomNumber = Random.Range(0, GameManager.numPersonajes); 
            
            }while (GameManager.visitados[randomNumber] == 1);  

            GameManager.contVisitados += 1;
            GameManager.visitados[randomNumber] = 1; 

            personajeDisplay.setPersonaje(personajes[randomNumber]);    

            GameManager.insignias -= 1;

            personajeDisplay.mostrar();

            popup.OpenPanel("Has obtenido a:\n" + personajes[randomNumber].nombrePersonaje);

            GameManager.personajesObtenidos.Add(personajes[randomNumber]);

            foreach (Personaje p in GameManager.personajesObtenidos){

                print(p.nombrePersonaje);
            
            }
            }          
            return;   
                                        
                       
        }
        else
        {
            personajeDisplay.ocultar();
            popup.OpenPanel("No quedan insignias restantes");
        }
    }

    
      
}
