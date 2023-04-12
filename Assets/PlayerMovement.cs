using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] public float _Speed;
    [SerializeField] public float _RSpeed;
    [SerializeField] public bool _WR;
    [SerializeField] public bool _Running;
    [SerializeField] public bool _WL;
    [SerializeField] public float SpeedCap;
    public float horizontal;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        horizontal = Input.GetAxisRaw("Horizontal");

        if (rb.velocity.x >= SpeedCap)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, SpeedCap);
        }
        if (rb.velocity.x <= -SpeedCap)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, -SpeedCap);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector2.right * _Speed * horizontal * Time.deltaTime, ForceMode2D.Impulse);
    }
}
