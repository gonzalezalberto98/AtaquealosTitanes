using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarPersonajesEquipo : MonoBehaviour
{

    public PersonajesObtenidosDisplay po; 
    public void Start()
    {
        po.mostrarPersonajesObentidosSinEquipo();
        po.mostrarPersonajesEquipo();
        po.mostrarStatsEquipo();
    }
    
    
}
