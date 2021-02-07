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
            textboxContainer.transform.position = new Vector3 (teleportTarget.transform.position.x +96.8f, teleportTarget.transform.position.y +150.2f, teleportTarget.transform.position.z -207f);
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
