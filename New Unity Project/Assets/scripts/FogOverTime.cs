using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FogOverTime : MonoBehaviour
{

    void Start()
    {
        RenderSettings.fog = true;
        RenderSettings.fogDensity = 0.013f;
        StartCoroutine(updateTheFog());
    }

    IEnumerator updateTheFog()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            RenderSettings.fogDensity += 0.003f;
            if(RenderSettings.fogDensity >= 0.2f)
            {
                SceneManager.LoadScene("GameOverMenu");
            }

        }
        //if you want to stop the loop, use: break;
    }
}