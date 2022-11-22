using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalMovement : MonoBehaviour
{
    [SerializeField] private float _Speed;
    void Update()
    {
        transform.Translate(-_Speed * Time.deltaTime, 0, 0);
    }

        spriteRenderer.flip.x = true;
        spriteRenderer.flip.x = false;



}
