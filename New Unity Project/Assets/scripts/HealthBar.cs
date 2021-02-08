using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    private float maxHP = 100, currHP, currHPSlow;

    public float damge = 50;



    public Image barFast, barSlow;

    void Start()
    {
        currHP = maxHP;
        currHPSlow = maxHP;        
    }

    float t = 0;

    void Update()
    {
        if(currHPSlow != currHP) 
        {
            currHPSlow = Mathf.Lerp(currHPSlow, currHP, t);
            t += 0.1f * Time.deltaTime;
        }
        
        barFast.fillAmount = currHP/maxHP;
        barSlow.fillAmount = currHPSlow / maxHP;

        if (currHP == 0)
        {
            FindObjectOfType<AudioManager>().Play("GameOver");
            Invoke("Restart", 3f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnTriggerEnter(Collider other)
    {
        currHP -= damge;
        t = 0;
    }

    

}
