using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausar : MonoBehaviour
{
    [SerializeField] private GameObject botondepausa;
    [SerializeField] private GameObject menupausa;
    public void pausa()
    {
        Time.timeScale = 0f;
        botondepausa.SetActive(false);
        menupausa.SetActive(true);

    }

    public void REANUDAR()

    {
        Time.timeScale = 1f;
        botondepausa.SetActive(true);
        menupausa.SetActive(false);
    }
    public void sali()
    {
        Debug.Log("salir");
        
    }
}