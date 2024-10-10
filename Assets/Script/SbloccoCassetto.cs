using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class SbloccoCassetto : MonoBehaviour
{
    [SerializeField]
    private string maniglia;
    [SerializeField]
    private string porta;
    public void sbloccoPorta()
    {
        GameObject.Find(maniglia).GetComponent<MeshRenderer>().material.color = Color.green;
        GameObject.Find(porta).GetComponent<XRGrabInteractable>().enabled = true;
    }
}
