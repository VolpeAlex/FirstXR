using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;

public class ColoraPennello : MonoBehaviour
{
    [SerializeField]
    //Stringa che indica il colore del pennello
    public string Colore { get; set; }
    public void Start()
    {
        Colore = "Bianco";
        GameObject.Find("punta").gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }
    //Metodo che serve a colorare gli oggetti che entrano in collisione (collision)
    public void OnCollisionEnter(Collision collision)
    {
        if (Colore == "Rosso")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            
        }else if (Colore == "Giallo")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (Colore == "Blu")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            
        }
        else if (Colore == "Bianco")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            GameObject.Find("punta").gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }


}
