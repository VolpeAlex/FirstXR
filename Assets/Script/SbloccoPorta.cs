using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SbloccoPorta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Scanner")
        {
            GameObject.Find("Scanner").GetComponent<MeshRenderer>().material.color = Color.green;
            GameObject.Find("Porta").GetComponent<XRGrabInteractable>().enabled= true;
        }
    }
}
