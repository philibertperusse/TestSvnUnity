using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        if(transform.position.x, -10, 25);
       { Vector3 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, -10, 25);
            transform.position = pos;

        }
        else();
        {
            transform.position = new Vector3(player.position.x, 0, -10);
        }
    }
  
}