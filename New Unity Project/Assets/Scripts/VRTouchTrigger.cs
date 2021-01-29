﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTouchTrigger : MonoBehaviour
{
    public Image imgGaze;
    public Image textBackground;



    public int distanceOfRay = 5000;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void CallText()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay) && _hit.transform.CompareTag("TextTrigger"))
        {

            _hit.transform.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();

        }


    }

    public void EndText()
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
    }

   
}