using System;
using UnityEngine;

public class LoopPractice : MonoBehaviour
{
    int loopCount = 21;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < loopCount; i++)
        {
            Debug.Log("You have" + loopCount + "loops");
        }
    }

}
