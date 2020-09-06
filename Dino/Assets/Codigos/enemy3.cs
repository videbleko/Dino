using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{

    public float velocidad;
    public GameObject name;
    private void Start()
    {
        if(name.tag == "ave")
         transform.position = new Vector3(4.62f, -1.86f, 0f);
        
        if (name.tag == "cactus")
            transform.position = new Vector3(4.62f, -2.127f, 0f);

    }

    void Update()
    {
        transform.position += new Vector3(-velocidad * Time.deltaTime,0f,0f);
    }
}
