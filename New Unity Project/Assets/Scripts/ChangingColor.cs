using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingColor : MonoBehaviour
{
    public GameObject myImage;

    

    public void RegularColor()
    {
        myImage.GetComponent<Image>().color = new Color32(31, 14, 48, 200);
    }

    public void MouseOverColor()
    {
        myImage.GetComponent<Image>().color = new Color32(100, 70, 130, 200);
    }
}
