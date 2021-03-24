using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KeyScript : MonoBehaviour
{

    bool keystate;
    public string sceneName;

    public void Start()
    {
         keystate = GetComponent<Keyinventory>().hasKey;
    }


    public void OpenDoor()
    {
        if (keystate == true) {

            SceneManager.LoadScene(sceneName);
        }
    }
}

