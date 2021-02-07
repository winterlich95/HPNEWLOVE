using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallLetter : MonoBehaviour
{
    public GameObject letter;
    public Transform teleportTarget;
    public bool isShown;

    public void TeleportImage()
    {
        if (!isShown)
        {
            letter.transform.position = teleportTarget.transform.position;
            letter.transform.rotation = teleportTarget.transform.rotation;
            isShown = true;
        }
        
        else
        {
            letter.transform.position = new Vector3(0f, 80f, 0f);
            isShown = false;
        }
    }
}
