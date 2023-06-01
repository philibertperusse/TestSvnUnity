using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aller_retour_2 : MonoBehaviour
{
    [SerializeField] private float _Speed;
    //private float speed = 2f;
    public float delay = 100f;

    // Update is called once per frame
    void Uptade()
    { 
        Debug.Log("System Update");
        //  transform.Translate(Vector2.left * Time.deltaTime * speed);
        transform.Translate(-_Speed* Time.deltaTime, 0, 0);
        {
            //Start a coroutine that will destroy the object after the specified delay

            StartCoroutine(DelayDestruction());
        }


        IEnumerator DelayDestruction()
        {   
    // Wait for the specified delay

        yield return new WaitForSeconds(delay);
        }

_Speed = _Speed * -1;

        {
            //Start a coroutine that will destroy the object after the specified delay

            StartCoroutine(DelayDestruction2());
        }


        IEnumerator DelayDestruction2()
        {
            // Wait for the specified delay

            yield return new WaitForSeconds(delay);
        }
        Debug.Log("Works");
        // InvokeRepeating("OnTriggerEnter2D", 2.0f, 0.3f);
    }
}
