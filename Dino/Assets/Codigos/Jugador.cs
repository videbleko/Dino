using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Jugador : MonoBehaviour
{

    Animator anim;
    public bool pisando;
    public float salto;
    public GameObject rst;
    public bool perdiste;

    private void Start()
    {
        pisando = false;
        rst.SetActive(false);
        anim = GetComponent<Animator>();
        perdiste = false;

    }



    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0) && pisando == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0f,salto,0f);
            pisando = true;
            anim.Play("salto");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "suelo")
        {
            pisando = false;
            anim.Play("correr");
          
        }

        if (collision.gameObject.tag == "ave" || collision.gameObject.tag == "cactus")
        {
            rst.SetActive(true);
            perdiste = true;
            anim.Play("salto");
        }
    }
}
