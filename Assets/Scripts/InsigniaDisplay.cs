using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InsigniaDisplay : MonoBehaviour
{
    public TextMeshProUGUI insigniaText;
    
    void Update()
    {
        insigniaText.text = GameManager.insignias.ToString();
    }

    public void añadir()
    {
        GameManager.insignias += 1;
    }
    
}
