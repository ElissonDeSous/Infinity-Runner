using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morte : MonoBehaviour
{

      public Animator MortePlayer;
  void OnTriggerEnter(Collider col)
  {
             if(col.gameObject.layer == 3)
        {
              
              SceneManager.LoadScene(1);
        }
  }
}
