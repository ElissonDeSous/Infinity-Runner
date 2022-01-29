using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject>Plataform = new List <GameObject>();
    public List<Transform> currentPlat = new List<Transform>();

     private Transform Player;
     private Transform CurrentPlatLimite;

    public int offset;
    private int PLataformIndex;
   void Start()
    {

       Player = GameObject.FindGameObjectWithTag("Perso").transform;

        for(int i = 0; i < Plataform.Count; i++)
        {
          Transform P =  Instantiate(Plataform[i],new Vector3(0,0,0*30 ),transform.rotation).transform;

          currentPlat.Add(P);
            offset +=30;

            CurrentPlatLimite = currentPlat[PLataformIndex].GetComponent<Plataforma>().Point;
        }
    }

    void Update()
    {
       float distance = Player.position.z - CurrentPlatLimite.position.z ;

        
        if(distance >= 5)
       {
           Reciclar(currentPlat[PLataformIndex].gameObject);
           PLataformIndex++;
             if(PLataformIndex > currentPlat.Count - 1)
             {
                 PLataformIndex = 0;
             }
           CurrentPlatLimite = currentPlat[PLataformIndex].GetComponent<Plataforma>().Point;
       }
       
    }
      public void Reciclar(GameObject Plataform)
    {
       Plataform.transform.position = new Vector3(0,0,offset);
       offset+=30;
    }
   
}
