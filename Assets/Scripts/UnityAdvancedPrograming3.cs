using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAdvancedPrograming3 : MonoBehaviour

{
    public GameObject [] objects;
    public int index;

    void Start()
    {
        //objects[0].SetActive(false);
        //objects[1].SetActive(false);

        for(int i = 1; i < objects.Length; i+=2)
        {

                objects[i].SetActive(false);
            
        }
   
    }

    void Update()
    {
        

    }
    

}
