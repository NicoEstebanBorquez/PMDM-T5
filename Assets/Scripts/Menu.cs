using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    //Carga la escena "Juego":
    public void func_iniciarJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    //Carga la escena "Créditos":
    public void func_irCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    //Vuelve la escena "Menu":
    public void func_volverMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Salir del juego
    public void func_salirJuego()
    {
        Application.Quit();
    }
}
