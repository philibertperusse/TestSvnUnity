using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int _coins;
   //https://medium.com/nerd-for-tech/creating-collectibles-in-unity-3314ed1e0ffd
    private void OnTriggerEnter2D (Collider2D collision)
    //private void OnTriggerEnter(Collider other)
    
    {
       // if (other.tag == "Player")
        
        Player.Instance.AddCoins();
        Destroy(this.gameObject);
        
    

     }
}
