using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float Direction;
    [SerializeField] private float _SCap;
    [SerializeField] private Rigidbody2D Enemyui;
    [SerializeField] public Collider2D Tilemap;
    [SerializeField] public Collider2D Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemyui.velocity.x > _SCap)
        {
            Enemyui.velocity = new Vector2(_SCap, Enemyui.velocity.y);
        }

        if (Enemyui.velocity.x < -_SCap)
        {
            Enemyui.velocity = new Vector2(-_SCap, Enemyui.velocity.y);
        }

        Enemyui.AddForce(new Vector2(Speed * Direction, 0f), ForceMode2D.Impulse);
        if(Enemy.IsTouching(Tilemap))
        {
            Debug.Log("YAY!!!!!");
            Direction = Direction * -1;
        }
    }
}
