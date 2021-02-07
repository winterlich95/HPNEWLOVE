using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public bool isShown;
    public Transform teleportTarget;
    public GameObject textboxContainer;


    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        TeleportTextbox();
    }


    private void TeleportTextbox()
    {
        if (!isShown)
        {
            textboxContainer.transform.position = teleportTarget.transform.position;
            textboxContainer.transform.rotation = teleportTarget.transform.rotation;
            isShown = true;
        }
        else
        {
            textboxContainer.transform.position = new Vector3(0f, -40f, 0f);
            isShown = false;
        }
    }
}
