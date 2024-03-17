using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public bool onGround;
    public float fuerza_x;

void Start()
 {
    
 }
    void Update()
    {
        
    if (Input.GetKeyDown(KeyCode.Space))
    {
         Vector3 fuerza = new Vector3(0,200,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.RightArrow))
    {
         Vector3 fuerza = new Vector3(0,0,80);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
         Vector3 fuerza = new Vector3(0,0,-80);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.UpArrow))
    {
         Vector3 fuerza = new Vector3(-80,0,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
     if (Input.GetKeyDown(KeyCode.DownArrow))
    {
         Vector3 fuerza = new Vector3(80,0,0);
    GetComponent<Rigidbody>().AddForce(fuerza);

    }
    
    

}




}