using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class EventsInClass : MonoBehaviour
{
    [SerializeField] private int[] rakamlar;

    private void Start()
    {
        rakamlar = new int[10];
        for (int i = 0; i < rakamlar.Length; i++)
        {
            rakamlar[i] = Random.Range(0, 100);
        }
    }
}
