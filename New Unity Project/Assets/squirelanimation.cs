using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squirelanimation : MonoBehaviour
{ 

    private Animator anim;
    private CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            anim.SetInteger("AnimationPar", 1);
        }
        else
        {
            anim.SetInteger("AnimationPar", 0);
        }



    }
}
