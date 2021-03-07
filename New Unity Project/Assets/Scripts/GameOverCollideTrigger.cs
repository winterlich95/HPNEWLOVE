using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollideTrigger : MonoBehaviour
{
    public Transform thePlayer;

    public void OnCollissionEnter(Collision hitObject)
    {
        if (hitObject.gameObject.transform == thePlayer)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
