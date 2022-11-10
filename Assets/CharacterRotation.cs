using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    private float zRot = 0f;
    public Transform playerObj;

    void FixedUpdate()
    {
        zRot = Mathf.Clamp(zRot, -25f, 25f);
    }
}
