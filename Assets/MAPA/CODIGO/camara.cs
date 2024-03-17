using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
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

    }


}
   
    
