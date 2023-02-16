using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    public Transform player;
    public float Speedx;
    public float Speedy;
    public float Height;
    void Update()
    {
        transform.position = new Vector3(player.position.x / Speedx, player.position.y / Speedy + Height, 128);

    }
}
