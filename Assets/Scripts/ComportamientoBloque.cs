using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoBloque : MonoBehaviour
{
    //RigidBody2D del bloque
    Rigidbody2D rbBloque;

    //SpriteRenderer del bloque
    SpriteRenderer spriterBloque;
    // Velocidad del bloque
    public float velocidadBloque = 5;

    void Start()
    {
        //Se obtiene el RigidBody asociado al objeto
        rbBloque = GetComponent<Rigidbody2D>();

        //Se obtiene el SpriteRenderer del bloque
        spriterBloque = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        //Llamada al método que mueve el bloque
        movimientoBloque(Input.GetAxisRaw("Horizontal") * velocidadBloque,
                   Input.GetAxisRaw("Vertical") * velocidadBloque);
    }


    public void movimientoBloque(float moveX, float moveY)
    {
        rbBloque.velocity = new Vector2(moveX, moveY);
    }
}
