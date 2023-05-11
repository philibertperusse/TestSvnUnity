using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetection : MonoBehaviour
{
    [SerializeField] public bool _Jumping;
    [SerializeField] private Collider2D GC ;
    void OnTriggerEnter2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            _Jumping = false;
            Debug.Log(false);
        }
    }
    void OnTriggerExit2D(Collider2D GC)
    {
        if (GC.gameObject.tag == "Ground")
        {
            _Jumping = true;
             Debug.Log(true);
        }
    }
    public bool Jumping( bool _Jumping)
    {
        return _Jumping;
    }

}
