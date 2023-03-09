using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 10;
   [SerializeField] private bool Isjumping;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !Isjumping)
            {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            Isjumping = true;
            Debug.Log("jumping true");
            }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            Isjumping = false;
        Debug.Log("jumping false");
    }
}


