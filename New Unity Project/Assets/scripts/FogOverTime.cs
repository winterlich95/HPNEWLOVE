using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            RenderSettings.fogDensity += 0.01f;

        }
        //if you want to stop the loop, use: break;
    }
}