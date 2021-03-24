using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyScript : MonoBehaviour
{

    public string sceneName;
    public GameObject key;
    public void OpenDoor()
    {

        if (!key.activeSelf)
        {

            SceneManager.LoadScene(sceneName);
        }
    }
}


