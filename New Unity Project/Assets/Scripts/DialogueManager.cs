using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text objectName;
    public Text dialogueText;
   public Animator animator;

    public Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartOrEndDialogue(Dialogue dialogue)
    {
        if (animator.GetBool("IsOpen") != true)
        {
            StartDialogue(dialogue);
        } else
        {
            DisplayNextSentence();
        }
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        objectName.text = dialogue.watchedObjectName;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

            

    }
    
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        StartCoroutine(EndDialogueAutomatically());

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    public IEnumerator EndDialogueAutomatically ()
    {
        yield return new WaitForSeconds(25);
        EndDialogue();
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

}
