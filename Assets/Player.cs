using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _coins;
   // public Text coinText;
    private static Player _instance;
    public static Player Instance
    {
        get
        {
          //  if (_instance == null)

                return _instance;
        }
    }
    void Awake()
    {
        _instance = this;
    }

    public void AddCoins()
    {
        _coins++;
    }
    //public void UptadeCoinText(int coins)
   // {
  //      coinText.text = "Coins: " + coins;
    //}
}