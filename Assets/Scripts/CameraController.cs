using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player; //Hara referencia a la posicion del jugador
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //Se necestia que se calcule inmediatamente cuando el juego empieza, pero solo se calculara una vez
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate() //Lanza esto despues de que todas las demas funciones se ejecuten
    {
        //Se necesita que se haga cada frame, cada vez que se cambia 'actualiza'
        transform.position = player.transform.position + offset; //Ajusta la posicion de la camara a la bola pero no la rotacion
    }
}
