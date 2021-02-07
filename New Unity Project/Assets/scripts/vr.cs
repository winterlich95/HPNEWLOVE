﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vr : MonoBehaviour
{
    public Image imgGaze;

    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 5000;
    private RaycastHit _hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if(Physics.Raycast(ray, out _hit, distanceOfRay))
        {
            if(imgGaze.fillAmount == 1 && _hit.transform.CompareTag("Teleport"))
            {
                _hit.transform.gameObject.GetComponent<tp>().TeleportPlayer();
            }
            
            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("SceneTrigger"))
            {
                _hit.transform.gameObject.GetComponent<SceneChange>().ChangeScene();
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("TextTrigger"))
            {
                _hit.transform.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            }

            if (imgGaze.fillAmount == 1 && _hit.transform.CompareTag("AudioTrigger"))
            {
                _hit.transform.gameObject.GetComponent<AudioManager>().Play("Pils");
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;


    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }

}
