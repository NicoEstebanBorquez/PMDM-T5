using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    //Carga la escena "Juego":
    public void func_iniciarJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    //Salir del juego
    public void func_salirJuego()
    {
        Application.Quit();
    }
}
