using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Instancia de SoundManager
    public static SoundManager instance;

    //Atributo para obtener el AudioSource
    private AudioSource source;
    void Start()
    {
        //Inicialización de la instancia
        instance = this;

        //Componente AudioSource
        source = GetComponent<AudioSource>();
    }

    //Método que reproduce el AudioClip que se le pase como atributo
    public void PlaySound()
    {
        source.Play();
    }
}
