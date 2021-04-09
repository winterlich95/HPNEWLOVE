using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
  
    
        public void OnCollisionEnter(Collision hitObject)
        {
            if (hitObject.collider.tag == "PlayerCollide")
            {
                Debug.Log("Collision");
                gameObject.SetActive(true);
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        public void ExiTButton()
        {
         SceneManager.LoadScene("");
         }
        
        public void RestartButton()
        {
        SceneManager.LoadScene("");
        }

}

