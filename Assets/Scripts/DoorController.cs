using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    
    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            bool doorState = animator.GetBool("isDoorOpen");

            if (doorState)
            {
                animator.SetBool("isDoorOpen", false);
            }
            else
            {
                animator.SetBool("isDoorOpen", true);
            }
        }
    }
}
