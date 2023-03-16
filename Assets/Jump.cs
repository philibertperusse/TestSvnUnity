using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 10f;
    [SerializeField] private bool _Isjumping;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_Isjumping)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            _Isjumping = true;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            _Isjumping = false;
        Debug.Log("jumping false");
    }
}



