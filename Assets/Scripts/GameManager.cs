using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Instancia del GameManager
    public static GameManager instance;

    //Text de Puntuacion y Puntuacion Record
    public Text txtPuntuacion;
    public Text txtPuntuacionRecord;

    //Text Mensaje de Victoria/Derrota
    public Text txtVictoriaDerrota;

    //Variables de Puntuacion
    int puntuacion;
    int puntuacionRecord;

    //Boton Menu
    public GameObject BotonMenuPrincipal;

    //MONEDAS:
    //Moneda_10
    public GameObject moneda_10_1_trigger;
    public GameObject moneda_10_2_trigger;

    //Moneda_20
    public GameObject moneda_20_trigger;

    //Moneda_30
    public GameObject moneda_30_1_trigger;
    public GameObject moneda_30_2_trigger;
    public GameObject moneda_30_3_trigger;

    //Limite
    public GameObject limite;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        if (instance != this)
        {
            Destroy(this);
        }

        //Se inicializa la puntuacion
        puntuacion = 0;

        //Se carga la puntuación Record en PlayerPrefs;
        puntuacionRecord = PlayerPrefs.GetInt("Puntuacion_Maxima");

        txtVictoriaDerrota.enabled = false;
        BotonMenuPrincipal.SetActive(false);
    }

    void Update()
    {
        //Se muestra el Record en la interfaz
        txtPuntuacionRecord.text = puntuacionRecord.ToString();
    }

    public void func_aumentarPuntuacion(int puntos)
    {
        //Contador de la puntuación actual
        puntuacion = puntuacion + puntos;
        txtPuntuacion.text = puntuacion.ToString();
    }

    //Carga la escena del Menu
    public void func_irMenu()
    {
        //Carga la escena anterior
        SceneManager.LoadScene("Menu");
    }

    //Metodo que se llamará cuando finalice el juego
    public void func_finJuego()
    {
        //Si se ha batido el último Record de puntuacion, se produce una VICTORIA: 
        if (puntuacion > puntuacionRecord)
        {
            //Se guarda el nuevo Record
            puntuacionRecord = puntuacion;
            PlayerPrefs.SetInt("Puntuacion_Maxima", puntuacionRecord);
            PlayerPrefs.Save();

            //Mensaje de Victoria:
            txtVictoriaDerrota.text = "¡Has ganado!\n\nHas establecido un nuevo Record!";
            txtVictoriaDerrota.enabled = true;
            BotonMenuPrincipal.SetActive(true);
        }
        else
        {
            //Si no se ha batido el Record, se produce una DERROTA:
            txtVictoriaDerrota.text = "¡Has perdido!\n\nNo has conseguido batir el Record actual.";
            txtVictoriaDerrota.enabled = true;
            BotonMenuPrincipal.SetActive(true);
        }
    }
}
