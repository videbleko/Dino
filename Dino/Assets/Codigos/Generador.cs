using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public Jugador jugador;
    public GameObject[] enemigos;

    void Start()
    {
        InvokeRepeating("llamada",0f,2.1f);
     }

    private void Update()
    {
        if(jugador.perdiste)
        {
            CancelInvoke();
        }
    }
    void llamada()
    {
        int rando = Random.Range(0,2);
        Instantiate( enemigos[rando], transform.position, Quaternion.identity);
    }

    
}
