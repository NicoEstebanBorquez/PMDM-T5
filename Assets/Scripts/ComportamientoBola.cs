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
            Debug.Log("Tocado: LIMITE");
        }
        else if(other.gameObject.name == "moneda_20_trigger")
        {
            GameManager.instance.aumentarPuntuacion(20);
        }
    }
}
