using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollideTrigger : MonoBehaviour
{

    public void OnCollisionEnter(Collision hitObject)
    {
        if (hitObject.collider.tag == "PlayerCollide")
        {
            Debug.Log("Collision");
            FindObjectOfType<GameOverScreen>().StartScreen();
        }
    }
}
