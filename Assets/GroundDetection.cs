using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    [SerializeField] public bool _IsJumping;
    [SerializeField] private Collider2D GC ;

    public void Function1()
    {
        _IsJumping = true;

    }
    void OnTriggerEnter2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            _IsJumping = false;
            Debug.Log(false);
        }
        else
        {
            _IsJumping = true;
        }
    }
    // void OnTriggerExit2D(Collider2D GC)
    //{
    // if (GC.gameObject.tag == "Ground")
    // {
    //    _IsJumping = true;
    //    Debug.Log(true);
    // }
    // }
}
