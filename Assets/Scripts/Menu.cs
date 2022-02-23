using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    //Text Record a batir
    public Text txtRecord;

    //Variables Puntuacion Record
   // int puntuacionRecord;


    void Start()
    {
        
       // puntuacionRecord = PlayerPrefs.GetInt("Puntuacion_Maxima");
       // Debug.Log("Record a batir (Desde Menu): " + puntuacionRecord);
       // txtRecord.text = "Record a batir: " + puntuacionRecord;
    }
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
