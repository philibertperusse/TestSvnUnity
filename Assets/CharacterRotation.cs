using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterRotation : MonoBehaviour
{   
    
    public Transform playerObj;

    void Update()
    {
        

        Vector3 rot = transform.rotation.eulerAngles; // Lire les angles en X, Y et Z de ton objet
        //Debug.Log("Rotation avant X="+rot.x+" Y="+rot.y+" Z="+rot.z);

        // rot.z = Mathf.Clamp(rot.z, -25f, 25f); // limiter l'angle à 25 degrés selon l'axe X
        if( rot.z > 25f && rot.z < 180f) rot.z = 25f;
        if( rot.z < (360f - 25f) && rot.z > 180f) rot.z = 360f - 25f;
         //transform.Rotate(0,0,rot.z,Space.Self); // Modifier l'angle de l'objet pour la valeur "limitee"
        transform.eulerAngles = rot;
        //Debug.Log("Rotation apres  "+transform.eulerAngles);


    }
}
