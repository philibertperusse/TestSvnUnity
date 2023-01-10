using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFlip : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float flipInterval = 1.0f; // seconds between flips
    public bool flipRight = true;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("Flip", flipInterval, flipInterval);
    }

    void Flip()
    {
        if (flipRight)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

        flipRight = !flipRight;
    }
}
