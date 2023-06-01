using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public float delay = 3f; // Number of seconds to delay destruction
   
   
    void OnCollisionEnter2D(Collision2D collision)
    {  
        //Start a coroutine that will destroy the object after the specified delay
       
       StartCoroutine(DelayDestruction());
    }


        IEnumerator DelayDestruction()
        {
            // Wait for the specified delay
       
     yield return new WaitForSeconds(delay);

    // Destroy the object
   Destroy(this.gameObject);

        }
}

    




