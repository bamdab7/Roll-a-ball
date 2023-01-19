using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //No se usaran fuerzas para rotar el cubo, lo que haremos sera hacer que el cubo rote mientras el juego está activo
    //Los valores de X,Y y Z asignados al principio setean una rotacion pero habria que hacer que cambien cada frame

    // Update is called once per frame
    void Update()
    { //Rotate gira el objeto por su transformacion
        //PAra hacer el movimiento de la accion suave e independiente de la velocidad de fotogramas...
        transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime); //Cambiara el valor en funcion de la longitud de un frame
 
    }
   
}
