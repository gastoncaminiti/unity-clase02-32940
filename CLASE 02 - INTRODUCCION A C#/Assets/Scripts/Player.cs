using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Creamos una variable para definir la posición inicial en Y.
    public float posicionY = 3f;

    void Start()
    {
       //A la posición del objeto actual le sumamos una nueva posición en Y. 
       transform.position  += Vector3.up * posicionY;
       transform.localScale = transform.localScale * 2;
    }

    // Update is called once per frame
    void Update()
    {
        //En cada frame, ala posición del objeto actual le sumamos una nueva posición en Z. 
        transform.position = transform.position + Vector3.forward * Time.deltaTime;
    }
}
