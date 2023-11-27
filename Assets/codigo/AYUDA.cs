using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AYUDA : MonoBehaviour
{
   public void Cambiardenivel(string nombredelnivel)
    {
        SceneManager.LoadScene(nombredelnivel);
    }
    public void Cambiardenivel(int numeronivel)
    {
        SceneManager.LoadScene(numeronivel);
    }
}
