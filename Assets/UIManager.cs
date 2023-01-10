using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text coinText;

    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            return _instance;

        }
    }
    void Awake()
    {
        _instance = this;
    }     

    public void UptadeCoinText(int coins)
    {

        coinText.text = "Coins: " + coins;
    }
   

}
