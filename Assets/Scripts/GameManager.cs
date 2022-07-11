using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static int insignias = 5;
    public static int dinero = 2000;

    public static List<Personaje> personajesObtenidos = new List<Personaje>();

    public static List<Personaje> equipo = new List<Personaje>();

    public static int numPersonajes = 9;
    public static int contVisitados = 0;
    public static int[] visitados = new int[numPersonajes];
    public int i = 0;
    
    private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;//Avoid doing anything else
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        for ( i = 0; i < numPersonajes; i++ ) {
            visitados[i] = 0;
         }
    }


    public static GameManager GetInstance()
    {
        return instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
