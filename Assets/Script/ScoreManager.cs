using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _score;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }
    [SerializeField]
    GameObject moneta;
    public void RaccogliMoneta()
    {
        Destroy(moneta.gameObject);
        GameObject.Find("GameManager").GetComponent<ScoreManager>().Score += 1000;
    }
    
}
