using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;
    private static readonly int Walking = Animator.StringToHash("Walking");
    private static readonly int Jumping = Animator.StringToHash("Jumping");

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool(Walking,false);
            anim.SetTrigger(Jumping);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool(Walking,true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool(Walking,false);
        }
    }
}
