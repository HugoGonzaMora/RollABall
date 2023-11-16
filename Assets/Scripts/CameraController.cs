using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //referncia al Game Object del jugador
    public GameObject player;
    //distancia entre camara y jugador
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        //calcular el offset inicial entre la posicion de la camara y la posicion del jugador
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame after all Update functions have been completed
    void LateUpdate()
    {
        //Mantiene el mismo offset entre la camara y el jugador durante el juego
        transform.position = player.transform.position + offset;
    }
}
