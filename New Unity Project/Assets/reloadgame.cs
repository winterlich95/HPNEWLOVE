using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class reloadgame : MonoBehaviour
{

    void Start()
    {

        StartCoroutine(updateTheFog());
    }

    IEnumerator updateTheFog()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
         
            {
                SceneManager.LoadScene("Demo Night");
            }

        }
        //if you want to stop the loop, use: break;
    }
}