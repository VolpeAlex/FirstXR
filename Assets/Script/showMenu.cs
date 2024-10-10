using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("DrawerUI").GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showUI()
    {
        GameObject.Find("DrawerUI").GetComponent<Canvas>().enabled = true;
    }
}
