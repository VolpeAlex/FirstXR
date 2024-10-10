using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBrushColor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public string Colore;
    //Metodo che imposta la variabile Colore del pennello, inoltre colora la punta del pennello
    public void SetColor()
    {
        if (Colore == "Rosso")
        {
            GameObject.Find("Pennello").GetComponent<ColoraPennello>().Colore = "Rosso";
            GameObject.Find("punta").gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if (Colore == "Giallo")
        {
            GameObject.Find("punta").gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            GameObject.Find("Pennello").GetComponent<ColoraPennello>().Colore = "Giallo";
        }else if(Colore == "Blu")
        {
            GameObject.Find("Pennello").GetComponent<ColoraPennello>().Colore = "Blu";
            GameObject.Find("punta").gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
