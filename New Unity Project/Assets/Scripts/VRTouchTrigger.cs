using System.Collections;
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


    public void CallJump()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay) && _hit.transform.CompareTag("JumpscareTrigger"))
        {

            _hit.transform.gameObject.GetComponent<JumpTrigger>().StartJump();

        }


    }

    public void CallText()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue(_hit.transform.gameObject.tag);

        }


    }


    public void CallSound()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay) && _hit.transform.CompareTag("AudioTrigger2"))
        {

            _hit.transform.gameObject.GetComponent<AudioManager>().Play("Brief");

        }
        
        }

    public void CallImage()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out _hit, distanceOfRay))
        {

            _hit.transform.gameObject.GetComponent<CallLetter>().TeleportImage();

        }
    }

        public void EndText()
    {
        FindObjectOfType<DialogueManager>().EndDialogue();
    }

   
}
