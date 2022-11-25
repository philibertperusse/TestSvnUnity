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
    
    
        //_spriteRenderer.flipX = ! _spriteRenderer.flipX    
        //alternement du flip sur x
    }


}
