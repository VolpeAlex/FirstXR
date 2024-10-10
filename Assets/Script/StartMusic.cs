using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    public void PlayMusic()
    {
        if (GameObject.Find("SongManager").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("SongManager").GetComponent<AudioSource>().Stop();
        }
        else{
            GameObject.Find("SongManager").GetComponent<AudioSource>().Play();
        }

}
}
