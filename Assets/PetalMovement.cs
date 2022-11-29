using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalMovement : MonoBehaviour
{

    [SerializeField] private float _Speed;
    SpriteRenderer _spriteRenderer;
    void Update()
    {
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);
    
    //mouvement des p�tales vers la gauche
    
    

        transform.Rotate(0, 0, 5 * Time.deltaTime);
        //rotates 50 degrees per second around z axis

        transform.Rotate(0, 0, 50 * Time.deltaTime);
        //rotates 50 degrees per second around z axis

        //List<String> _spriteRenderer = new List<String>();
        //_spriteRenderer.flipX = ! _spriteRenderer.flipX;    
        //alternement du flip sur x

    }


}
