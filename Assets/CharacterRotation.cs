using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    private float zRot = 45;
    public Transform playerObj;

    void FixedUpdate()
    {
        zRot = Mathf.Clamp(45, -25, 25);
    }
}
