using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "Nueva Insignia", menuName = "Insignia")]
public class Insignia : ScriptableObject
{
    public int numInsignias;
    
    public Insignia(int n)
    {
        this.numInsignias = n;
    }
    public void añadirInsignias(int n)
    {
        numInsignias += n;
    }

    public void eliminarInsignias(int n)
    {
        numInsignias -= n;
    }

    public int getInsignias()
    {
        return numInsignias;
    }
}
