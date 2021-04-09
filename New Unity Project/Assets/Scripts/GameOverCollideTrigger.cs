using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollideTrigger : MonoBehaviour
{
    public GameObject player;
    
    public void OnTriggerEnter(Collider player)
    {
        
            Debug.Log("Collision");
            SceneManager.LoadScene("a1");

    }
}
