using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class One : Task
{
    private int _myInt;
    private float _myFloat;
    private string _myString;
    
    private One()
    {
        _myInt = Random.Next(0, 125);
        _myFloat = RandomFloatArray();
        _myString = "Furkan";
    }
    
    private void Start()
    {
        IfCondMethod();
        SwitchMethod();
        WhileMethod();
    }
    
    private void IfCondMethod()
    {
        if (_myInt % 2 == 0)
        {
            Debug.Log("Even");
        }
        else
        {
            Debug.Log("Odd");
        }
    }
    
    private void SwitchMethod()
    {
        switch(_myFloat)
        {
            case 1.2f:
                Debug.Log("Number 1.2f");
                break;
            case 2.5f:
                Debug.Log("Number 2.5f");
                break;
            case 3.8f:
                Debug.Log("Number 3.8f");
                break;
            default:
                Debug.Log("Another number");
                break;
        }
    }
    
    private void WhileMethod()
    {
        while (_myString.Length > 0)
        {
            Debug.Log(_myString);
            _myString = _myString.Substring(1);
        }
        
    }
    
}
