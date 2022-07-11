using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PersonajesObtenidos : ScriptableObject
{
    public GameObject personajeInfo;

    public void añadirPersonaje()
    {
        if (personajeInfo != null)
        {
            personajeInfo.SetActive(true);
        }
    }
}
