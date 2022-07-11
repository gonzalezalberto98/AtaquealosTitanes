using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public GameObject Panel;

    public TextMeshProUGUI mensajeText;
   
    public void OpenPanel(string mensaje)
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            this.mensajeText.text = mensaje;
        }
    }

    public void OpenPanelEmpty(){
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
