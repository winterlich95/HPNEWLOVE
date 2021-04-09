using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Animator animator;
    
        public void OnCollisionEnter(Collision hitObject)
        {
            if (hitObject.collider.tag == "PlayerCollide")
            {
                Debug.Log("Collision");
                gameObject.SetActive(true);
                FindObjectOfType<GameManager>().EndGame();
            }
        }

        public void StartScreen()
    {
        Debug.Log("StartScreen wurde ausgeführt.");
        if (animator.GetBool("IsOpen") == false)
        {
            animator.SetBool("IsOpen", true);
        }
        //FindObjectOfType<PlayerMovement>().enabled = false;
        //FindObjectOfType<MouseLook>().enabled = false;

    }

        public void ExiTButton()
        {
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene("");
         }
        
        public void RestartButton()
        {
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene("");
        }

}

