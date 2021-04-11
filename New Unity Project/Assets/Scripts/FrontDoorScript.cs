using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrontDoorScript : MonoBehaviour
{
    public Dialogue closedDoorDialogue;
    public Dialogue questText;
    public Dialogue openedDoorDialogue;
    public Dialogue questComplete;
    public string sceneName;
    public GameObject key;




    public void OpenDoor()
    {
        if (!key.activeSelf)
        {
            FindObjectOfType<QuestTextManager>().StartDialogue(questComplete);
            FindObjectOfType<DialogueManager>().StartOrEndDialogue(openedDoorDialogue);
            StartCoroutine(TriggerSceneChange());
        } else
        {
            FindObjectOfType<QuestTextManager>().StartDialogue(questText);
            FindObjectOfType<DialogueManager>().StartOrEndDialogue(closedDoorDialogue);
        }
    }

    public IEnumerator TriggerSceneChange()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(sceneName);
    }
}
