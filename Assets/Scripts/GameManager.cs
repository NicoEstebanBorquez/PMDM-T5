using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //Text de Puntuacion
    public Text txtPuntuacion;
    //public Text txtPuntuacionMax;

    //Text Victoria/Derrota
    public Text txtVictoriaDerrota;

    //Boton Menu
    public GameObject BotonMenuPrincipal;

    //Variables de Puntuacion
    int puntuacion;
    int puntuacionRecord;

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



    // Start is called before the first frame update
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

        //Se carga la puntuación almacenada en PlayerPrefs;
        puntuacionRecord = PlayerPrefs.GetInt("Puntuacion_Maxima");
        Debug.Log("Record a batir: " + puntuacionRecord);

        txtVictoriaDerrota.enabled = false;
        BotonMenuPrincipal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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

    //Metodo que se llamará cuando cuando la bola caiga por el agujero
    public void func_bolaCaePorAgujero()
    {
        /*Si cuando la bola cae por el agujero se ha batido el último Record 
          de puntuacion, se produce una VICTORIA: */
        if (puntuacion > puntuacionRecord)
        {
            //Se guarda el nuevo Record
            PlayerPrefs.SetInt("Puntuacion_Maxima", puntuacionRecord);
            PlayerPrefs.Save();


            txtVictoriaDerrota.text = "WIN! " + puntuacion + " Has establecido un nuevo Record!";
            txtVictoriaDerrota.enabled = true;
            BotonMenuPrincipal.SetActive(true);
        }

        //Si no se ha batido el Record, se produce una DERROTA:
        if (puntuacion <= puntuacionRecord)
        {
            txtVictoriaDerrota.text = "GAME OVER " + puntuacion + " No has conseguido batir el Record actual.";
            txtVictoriaDerrota.enabled = true;
            BotonMenuPrincipal.SetActive(true);
        }

    }
}
