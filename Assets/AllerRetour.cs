using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllerRetour : MonoBehaviour
{
    [SerializeField] private float _Speed;
    private float speed = 2f;
    public float delay = 3f;
    //Moves this GameObject 2 units a second in the forward direction
  
   
    
     void Uptade()
     {
         Debug.Log("System Update");
        //  transform.Translate(Vector2.left * Time.deltaTime * speed);
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);
        {
            //Start a coroutine that will destroy the object after the specified delay

            StartCoroutine(DelayDestruction());
        }


        IEnumerator DelayDestruction()
        {
            // Wait for the specified delay

            yield return new WaitForSeconds(delay);
        }

        speed = speed * -1;
        Debug.Log("Works");
        // InvokeRepeating("OnTriggerEnter2D", 2.0f, 0.3f);
     }
    //Upon collision with another GameObject, this GameObject will reverse direction
    //void OnTriggerEnter2D(Collider2D collision)
    //{
           // speed = speed * -1;
           // Debug.Log("works!");


           // {
              //  //Start a coroutine that will destroy the object after the specified delay

             //   StartCoroutine(DelayDestruction());
            //}


         //   IEnumerator DelayDestruction()
          //  {
                // Wait for the specified delay

          //      yield return new WaitForSeconds(delay);
           // }
        

    //}
 
}
// if (other.gameObject.CompareTag("CDB"))

//other.gameObject.CompareTag("CDB")