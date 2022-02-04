using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //Moneda_20
    public GameObject moneda_20_trigger;

    //Limite
    public GameObject limite;

    //Puntuacion
    int puntuacion;
    int puntuacionMax;

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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void aumentarPuntuacion(int puntos)
    {
        puntuacion = puntuacion + puntos;
        Debug.Log(puntuacion);
    }
}
