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

        Debug.Log("break");

        for (int i = 0; i < numbers2.Length; i++)
        {
            Debug.Log(numbers2[i]);
        }

        Debug.Log("break");

        for (int i = numbers1.Length - 1; i >= 0; i--)
        {
            Debug.Log(numbers1[i]);
        }

        Debug.Log("break");

        int [] squares = new int[numbers1.Length];

        for (int i = 0; i < numbers1.Length; i++)
        {
            int square = numbers1[i] * numbers1[i];
            
            squares[i] = square;

            Debug.Log(squares[i]);
        }

        Debug.Log("break");

        int sum = 0;
        int sumSquare = 0;

        for (int i = 0; i < numbers1.Length; i++)
        {
            sum = sum + numbers1[i];
            sumSquare = sumSquare + squares[i];
        }

        Debug.Log(sum);
        Debug.Log(sumSquare);

        Debug.Log("break");


        int[] cubes = new int[5];

        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i] = (i+1) * (i+1) * (i+1);
            Debug.Log(cubes[i]);
        }

        Debug.Log("break");


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
