using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velRot;
    public float velpul;


    public Animator animPulo;
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
           transform.Translate(-velRot,0,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.D)){
           transform.Translate(velRot,0,0);
        }

        Pulo();
    }

    void Pulo()
    {
         if(Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.Space))
         {
            animPulo.SetInteger("pulo",1);
         }
    }
}
