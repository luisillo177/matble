using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("ObjetoADestruir"))
        {
            // Destruir este objeto
            Destroy(gameObject);
        }
    }
}