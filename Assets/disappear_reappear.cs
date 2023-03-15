using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear_reappear : MonoBehaviour

  //  public Transform player;
  //  public Transform gameObject;
  //public Vector3 position;

  //  void Update()
  //  {
  //     if(transform.position.x = Vector3(player.position.x +20f, transform.position.y, transform.position.z))
    //    {
       //     gameObject.transform.position = new Vector3(player.position.x -20f, 20f, 20f);
       // }
   //}
   
   // if(transform.position.x <= player.position.x -20)
    //   {
  //      transform.position = new Vector3(20f, 20f, 20f);
//}
//transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f)
//using UnityEngine;

//public class MoveObjectToLocation : MonoBehaviour
{
    // public Transform target; // the target location to move the object to
    // public float speed;
    // private bool hasReachedTarget = false; // flag to track whether the object has reached the target

    // void Update()
    // {
    // check if the object hasn't reached the target yet
    // if (!hasReachedTarget)
    // {
    // check if the object has arrived at the target position
    // if (transform.position == target.position)
    // {
    //  hasReachedTarget = true;
    // Debug.Log("Target arrived");
    // transform.position = new Vector3(20f, 20f, 20f);
    // }
    // else
    // {
    // move the object towards the target position
    //transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
    //  }
    // }
    // }
    public Transform target; // the target location to move the object to

    private bool hasReachedTarget = false; // flag to track whether the object has reached the target

    void OnTriggerEnter(Collider other)
    {
        // check if the object colliding with the trigger is the object we want to move
        if (other.gameObject == gameObject)
        {
            // if the object hasn't reached the target yet, move it to the target location
            if (!hasReachedTarget)
            {
                transform.position = target.position;
                hasReachedTarget = true;
            }
        }
    }


}

