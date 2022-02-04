using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoBola : MonoBehaviour
{
    //RigidBody2D de la bola
    Rigidbody2D rbBola;

    // Velocidad de la bola
    public float velocidadBola = 5;
    void Start()
    {
        //Se obtiene el RigidBody asociado al objeto
        rbBola = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "moneda_20")
        {
            Debug.Log("Tocado: moneda_20");
        }
        else
        {
            Debug.Log("Tocado: otro");
        }
    }
}
