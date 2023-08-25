using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task : MonoBehaviour
{
    protected readonly System.Random Random = new();
    
    protected float RandomFloatArray()
    {
        float[] myFloatArray = new float[5];
        myFloatArray[0] = 1.2f;
        myFloatArray[1] = 2.5f;
        myFloatArray[2] = 3.8f;
        myFloatArray[3] = 4.1f;
        myFloatArray[4] = 5.4f;
        return myFloatArray[Random.Next(0, 5)];
    }
}
