using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DineroDisplay : MonoBehaviour
{
    public TextMeshProUGUI dineroText;
    
    void Update()
    {
        dineroText.text = GameManager.dinero.ToString();
    }

    public void añadir(int n)
    {
        GameManager.dinero += n;
    }
}
