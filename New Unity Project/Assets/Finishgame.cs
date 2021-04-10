using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finishgame : MonoBehaviour
{
    public Dialogue closedDoorDialogue;

    public void KeyPick()
    {
        
        FindObjectOfType<DialogueManager>().StartOrEndDialogue(closedDoorDialogue);
       
        StartCoroutine(EndJump());
    }


    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(10f);

        StopAllCoroutines();
        SceneManager.LoadScene("GameMenu");

    }
}