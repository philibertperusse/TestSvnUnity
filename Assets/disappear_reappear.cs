using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear_reappear : MonoBehaviour


{ 
    [SerializeField] private float _Speed;
    SpriteRenderer _spriteRenderer;

    void Uptade()
    {
        Debug.Log("Calling of the script");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);

    }
}

