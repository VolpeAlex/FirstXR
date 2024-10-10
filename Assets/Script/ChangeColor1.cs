using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor1 : MonoBehaviour
{
    // Start is called before the first frame update
    bool rotate;
    public void colorChange()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
    public void colorBack()
    {
        GetComponent<MeshRenderer>().material.color= Color.white;
    }
    public void rotateOnSelected()
    {
         rotate=true;
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (rotate)
        {
            transform.Rotate(0.5f, 0, 0);
        }
    }
}
