using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public bool isShown;
    //public Transform teleportTarget;
    //public GameObject textboxContainer;


    public void TriggerDialogue(string tag)
    {
        switch(tag)
        {
            case "TextTrigger":
                FindObjectOfType<DialogueManager>().StartOrEndDialogue(dialogue);
                break;

            case "QuestboxTrigger":
                FindObjectOfType<QuestTextManager>().StartDialogue(dialogue);
                break;

            default:
                Debug.Log("The Textbox Trigger does not seem to have the correct Tag.");
                break;
        }
        
        
        //TeleportTextbox();
    }


    //method for vr-friendly text, not necessary anymore
    //private void TeleportTextbox()
    //{
    //    if (!isShown)
    //    {
    //        textboxContainer.transform.position = teleportTarget.transform.position;
    //        textboxContainer.transform.rotation = teleportTarget.transform.rotation;
    //        isShown = true;
    //    }
    //    else
    //    {
    //        textboxContainer.transform.position = new Vector3(0f, -40f, 0f);
    //        isShown = false;
    //    }
   // }
}
