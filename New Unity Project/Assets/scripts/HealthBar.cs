using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    private float maxHP = 100, currHP, currHPSlow;

    public float damge = 10;



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
            // TO DO Game Over Display/Text Box
            Invoke("Restart", 2f);
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
