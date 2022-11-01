using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    [SerializeField] private float _Speed;

    
    void Update()
    {
        transform.Translate(_Speed * Time.deltaTime, 0, 0);
    }
}
