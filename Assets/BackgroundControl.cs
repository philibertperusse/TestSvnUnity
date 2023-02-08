using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    public Transform player;
    public float Speed;
    public float Height;
    void Update()
    {
        transform.position = new Vector3(player.position.x / Speed, player.position.y / Speed + Height, 128);

    }
}
