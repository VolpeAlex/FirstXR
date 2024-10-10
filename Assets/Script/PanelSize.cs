using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PanelSize : MonoBehaviour
{
    public void changeSizePanel() 
    {
            float size = 0.01852305f;
            float slider = GameObject.Find("Slider").GetComponent<Slider>().value;
            float value=size*slider;
            GameObject.Find("Panel").GetComponent<RectTransform>().localScale = new Vector3(value,value,value);
    } 
}
