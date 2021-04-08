using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour
{
    public Animator animator;

    public void ChangeState()
    {
        if (animator.GetBool("IsOpen") == true)
         {
             Despawn();
         } else
         {
              MakeActive();
         }
        Debug.Log("Der Trigger funktioniert.");
    }
   

    public void MakeActive()
    {
        animator.SetBool("IsOpen", true);
        StopAllCoroutines();
        StartCoroutine(DespawnNoteAutomatically());
    }

    public IEnumerator DespawnNoteAutomatically()
    {
        yield return new WaitForSeconds(20);
        Despawn();
    }

    public void Despawn()
    {
        animator.SetBool("IsOpen", false);
    }

   
}
