using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSprint : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float dirX;

    private void Uptade()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _speed = 10f;

        else
            _speed = 5f;

        dirX = Input.GetAxis("Horizontal") + _speed;
    }

    private void FixedUptade()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y);
    }


}
