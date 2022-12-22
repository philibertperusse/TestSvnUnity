using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
   

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



 }
