using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animfix : MonoBehaviour
{
    
    public Animator anim;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Squirel"))
        {
            anim.SetBool("isrunning", false);

        }

    }
}
