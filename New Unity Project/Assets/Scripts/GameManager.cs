using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool hasEnded = false;

    public void EndGame() {

        if(!hasEnded)
        {
            hasEnded = true;
            Debug.Log("You lose >:)");
            Restart();
        }
     

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
