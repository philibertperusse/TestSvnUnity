using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField] private float _Speed;
    [SerializeField] private float _runningSpeed;
    [SerializeField] private float jumpforce;
    private bool _IsGrounded;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(_Speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-_Speed * Time.deltaTime, 0, 0);

        if ((Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.RightArrow)))
            transform.Translate(_Speed * _runningSpeed * Time.deltaTime, 0, 0);

        if ((Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.LeftArrow)))
            transform.Translate(-_Speed * _runningSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.Space))
            transform.Translate(0, jumpforce * Time.deltaTime, 0);
//
       


    }
}

