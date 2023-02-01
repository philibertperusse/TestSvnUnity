using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public float delay = 3f; // Number of seconds to delay destruction
    //void Uptade();
    
   //public float delay = 3f; // Number of seconds to delay destruction

    private void OnCollision2DEnter(Collision2D collision) {
        // Start a coroutine that will destroy the object after the specified delay
        //  StartCoroutine(DelayDestruction());
        // }

        //private IEnumerator DelayDestruction()
        //  {
        // Wait for the specified delay
        //yield return new WaitForSeconds(delay);

        // Destroy the object
        Destroy(this.gameObject); }

    
}

    //[SerializeField] delay
    // void Uptade OnCollison2DEnter(Collision2D collision)
    // {

    //   yield WaitForSeconds(3);
    //  Destroy(gameObject);
    //}
    //return new
    //[SerializeField] delay;
    //{
    //if(var delay = 3.0)
    // { 
    //Destroy.gameObject;
    // }
    // var delay = 2.0; //This implies a delay of 2 seconds.
    // function WaitAndDestroy()
    // {
    //  yield WaitForSeconds(delay);
    //   Destroy(gameObject);
    // }
    //function OnCollisionEnter(Collision2D : Collision){

    // if (collision.transform.name == "kylan")
    // {

    //  Destroy(gameObject, "3");

    //}






