using UnityEngine;

public class Keyinventory : MonoBehaviour
{
    public Dialogue closedDoorDialogue;

    public void KeyPick()
    {
        this.gameObject.SetActive(false);
        FindObjectOfType<QuestTextManager>().StartDialogue(closedDoorDialogue);
    }



}