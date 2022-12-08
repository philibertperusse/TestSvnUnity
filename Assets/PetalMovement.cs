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

        //mouvement des p�tales vers la gauche



        //transform.Rotate(0, 0, 5 * Time.deltaTime);
        //rotates 50 degrees per second around z axis

        // transform.Rotate(0, 0, 5 * Time.deltaTime);
        //rotates 50 degrees per second around z axis

        //_spriteRenderer = new SpriteRenderer();
        //_spriteRenderer.flipX = false;
        // public new _spriteRenderer = other.GetComponent<SpriteRenderer>();
        // _spriteRenderer = GameObject.FindObjectWithTag(“Player”).GetComponent<SpriteRenderer>();
        // _spriteRenderer.flipX = ! _spriteRenderer.flipX;
        //alternement du flip sur x
        //if (_spriteRenderer.flipX == true)
        //_spriteRenderer.flipX = false;
        //else
        //_spriteRenderer.flipX = true;
        
    }


}
