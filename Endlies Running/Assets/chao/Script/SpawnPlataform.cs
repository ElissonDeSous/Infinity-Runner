using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour
{
    public List<GameObject>Plataform = new List <GameObject>();


    public int offset;
   void Start()
    {
        for(int i = 0; i < Plataform.Count; i++)
        {
            Instantiate(Plataform[i],new Vector3(0,0,0*30 ),transform.rotation);
            offset +=30;
        }
    }
   public GameObject Plata;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
           Reciclar(Plata);
        }
    }

    public void Reciclar(GameObject Plataform)
    {
       Plataform.transform.position = new Vector3(0,0,offset);
       offset+=30;
    }
}
