using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    [SerializeField] private bool IsJumping;
    [SerializeField] private Collider2D GC ;


    public void OnTriggerEnter2D(Collider2D GC)
    {
        if(GC.gameObject.tag == "Ground")
        {
            IsJumping = false;
        }
    }

    public void OnTriggerExit2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            IsJumping = true;
        }
    }
}
