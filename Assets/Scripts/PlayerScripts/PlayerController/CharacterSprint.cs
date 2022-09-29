using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSprint : MonoBehaviour
{

    float _speed = 5f;
    float dirX;
   
        
        private void Uptade()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            _speed = 10f;
        else
            _speed = 5f;

        dirX = Input.GetAxis("Horizontal") + _speed;
    }
}
