using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jump_height : MonoBehaviour
{
    public Rigidbody2D rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 20;
    float jumpTime;
    bool _jumping;
    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumping = true;
            jumpTime = 0;
        }
        if (_jumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpAmount);
            jumpTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space) | jumpTime > buttonTime)
        {
            _jumping = false;
        }

    }
}