using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untersuchehaus : MonoBehaviour
{

    public Dialogue dialogue;
    public Dialogue questtext;

    public bool isStarted;




        //TeleportTextbox();
    
    public void triggerquest()
    {
        FindObjectOfType<DialogueManager>().StartOrEndDialogue(dialogue);
        if (isStarted ==false)
        {
            FindObjectOfType<QuestTextManager>().StartDialogue(questtext);
       

        }
    }
}
   