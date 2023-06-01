using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalMovement : MonoBehaviour
{

    [SerializeField] private float _Speed;
    //[SerializeField] private float _spriteRenderer;
    SpriteRenderer _spriteRenderer;
    void Update()
    {
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);

        //mouvement des pétales vers la gauche
        
    }


}
