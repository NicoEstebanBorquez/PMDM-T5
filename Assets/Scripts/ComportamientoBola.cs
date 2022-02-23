using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoBola : MonoBehaviour
{
    //RigidBody2D de la bola
    Rigidbody2D rbBola;

    //SpriteRenderer del bloque
    SpriteRenderer spriterBola;


    // Velocidad de la bola
    public float velocidadBola = 5;
    void Start()
    {
        //Se obtiene el RigidBody asociado al objeto
        rbBola = GetComponent<Rigidbody2D>();

        //Se obtenemos el SpriteRenderer del bloque
        spriterBola = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "limite")
        {
            //Sonido Game Over
            SoundManager.instance.PlaySound();
            GameManager.instance.func_bolaCaePorAgujero();
        }
        else if (other.gameObject.name == "moneda_10_1_trigger" || 
        other.gameObject.name == "moneda_10_2_trigger")
        {
            GameManager.instance.func_aumentarPuntuacion(10);
            SoundManager.instance.PlaySound();
        }
        else if (other.gameObject.name == "moneda_20_trigger")
        {
            GameManager.instance.func_aumentarPuntuacion(20);
            SoundManager.instance.PlaySound();
        }
        else if (other.gameObject.name == "moneda_30_1_trigger" ||
        other.gameObject.name == "moneda_30_2_trigger" ||
        other.gameObject.name == "moneda_30_3_trigger")
        {
            GameManager.instance.func_aumentarPuntuacion(30);
            SoundManager.instance.PlaySound();
        }
    }
}
