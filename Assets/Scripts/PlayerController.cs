using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //Me permite acceder al codigo y las funciones(?

public class PlayerController : MonoBehaviour
{
    //Variable de velocidad para controlar la velocidad del jugador
    public float speed = 0; //Al ser publica la podemos ver en el inspector de unity (para manipularla)

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Establece el valor de la variable rb al obtener una ref al comp Rigibody adjunto a la esfera del jugador
        //El jugador sera capaz de mover la esfera de inmediato
    }

    void OnMove(InputValue movementValue)
    {
        //movementValue capturara y almacenara los datos de la direccion X e Y y la direccion de los dispositivos de entrada
        Vector2 movementVector = movementValue.Get<Vector2>();
        //Obtiene los datos de Vector2 del valor del movimiento y los alamcena en una variable que el Vector2 movementVector

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Funcio de actualizacion fija para que pueda llamar y agregar fuerza en el Rigibody almacenado en la variable rb
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX,0.0f, movementY);

        rb.AddForce(movement * speed); //Se le multiplica la 'fuerza' que estamos añadiendo
    }

    //Necesitamos que detecte y pruebe las colisiones en la esfera de la bola jugador, cada vez que la bola toque un objeto con tag, se ejecuta codigo
    private void OnTriggerEnter(Collider other)
    {
        //Compara el tag de los objetos en un valor string
        if (other.gameObject.CompareTag("PickUp"))
        {
        //La funcion detectara el contacto entre el jugador y los objetos pero sin crear una colision actual
         //La funcion debera apliarse solo a los objetos pickup
         other.gameObject.SetActive(false); 
        }
    } 
}
