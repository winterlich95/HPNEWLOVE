using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTrigger : MonoBehaviour
{
    public GameObject canvasObject;

    public void ChangeState()
    {
        if (canvasObject.gameObject.activeSelf == true)
        {
            canvasObject.gameObject.SetActive(false);
        }
        else
        {
            MakeActive();
        }
    }

    

    public void MakeActive()
    {
        canvasObject.gameObject.SetActive(true);
        StopAllCoroutines();
        StartCoroutine(DespawnNoteAutomatically());

    }

    public IEnumerator DespawnNoteAutomatically()
    {
        yield return new WaitForSeconds(20);
        canvasObject.gameObject.SetActive(false);
    }
}