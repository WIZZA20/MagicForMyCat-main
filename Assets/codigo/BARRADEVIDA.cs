using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BARRADEVIDA : MonoBehaviour
{
    private Slider slider;

    private void start()
        {
        slider = GetComponent<Slider>();
        }
   
    public void  Cambiarvidamaxima(float vidamaxima)
    {
        slider.maxValue = vidamaxima;

    }

    public void Cambiarvidaactual(float cantidaddevida)
    {
        slider.value = cantidaddevida; 

    }

    public void inicializarbarradevida(float cantidaddevida)
    {
        Cambiarvidaactual(cantidaddevida);
        Cambiarvidamaxima(cantidaddevida);
    }
}

