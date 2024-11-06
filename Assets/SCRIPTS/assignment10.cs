using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignment10 : MonoBehaviour
{
    // Start is called before the first frame update
    int Multiply(int a, int b)
    {
        return a * b;
    }
    void Start()
    {

        // int j = 5;
        // for (int i = 1; i <= 10; i++)
        // {
        //     Debug.Log(i * j);
        // }

        int number = 5;
        for (int i = 1; i <= 10; i++)
        {
            int result = Multiply(number, i);
            // Debug.Log($" {i}*{number} = {result}");
            Debug.Log(i + " X " + number + "=" + result);
        }

    }

}
