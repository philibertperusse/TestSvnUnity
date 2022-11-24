using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalMovement : MonoBehaviour
{
   
    [SerializeField] private float _Speed;
    void Update()
    {
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);
    
    //mouvement des pétales vers la gauche
    
    
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        //rotates 50 degrees per second around z axis
    }


}
