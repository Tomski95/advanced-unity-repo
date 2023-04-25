using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAdvancedPrograming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(i);
        }

        int [] numbers1 = new int[] { 10, 11, 12, 13 };
        int [] numbers2 = new int[5];

        for (int i = 0; i < numbers1.Length; i++)
        {
            Debug.Log(numbers1[i]);
        }

        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
