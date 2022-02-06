using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //Text de Puntuacion
    public Text txtPuntuacion;
    public Text txtPuntuacionMax;

    //Variables de Puntuacion
    int puntuacion;
    int puntuacionMax;

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

        //Se carga la puntuación almacenada en PlayerPrefs
        puntuacionMax = PlayerPrefs.GetInt("Puntuacion_Maxima");
        Debug.Log("Puntuacion maxima: " + puntuacionMax);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void aumentarPuntuacion(int puntos)
    {
        puntuacion = puntuacion + puntos;
        txtPuntuacion.text = puntuacion.ToString();

        //Se almacena la puntuación máxima en PlayerPrefs

        if (puntuacion > puntuacionMax)
        {
            puntuacionMax = puntuacion;
            Debug.Log("NUEVA Puntuacion maxima: " + puntuacionMax);
        }

        
        //Condicion de victoria
        if (puntuacion >= 3)
        {
            //gameOver.text = "VictoriA";

            //Muestra el boton Menu
            //BotonMenuPrincipal.SetActive(true);
            //Se guarda la puntuacion maxima
            
            PlayerPrefs.SetInt("Puntuacion_Maxima", puntuacionMax);
            PlayerPrefs.Save();
        }
    }
}
