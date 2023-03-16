using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jump_height : MonoBehaviour
{
    public Rigidbody2D rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 10;
    public float Run = 2;
    float jumpTime;
    bool _jumping;
    [SerializeField] private bool Isjumping;
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && !Isjumping)
        {
            _jumping = true;
            jumpTime = 0;
            Isjumping = true;
        }
        if (_jumping)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            jumpTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space) | jumpTime > buttonTime) 
        {
            _jumping = false;
        }
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Isjumping = false;
            Debug.Log("jumping false");
        }
    }
}
