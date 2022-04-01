using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    public float audioOffset;

    public bool canStartPlaying = false;
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        StartCoroutine("PlayMusic");
    }


    IEnumerator PlayMusic()
    {
        yield return new WaitForSeconds(audioOffset);
        audioSource.Play();

    }
}
