using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Obstacle : MonoBehaviour
{
    public AudioReverbZone audioReverbZone;

    private Volume PPvolume;
    void Start()
    {
        audioReverbZone = transform.GetComponentInParent<AudioReverbZone>();
        PPvolume = transform.GetComponentInParent<Volume>();

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player"))
        {
            StartCoroutine(ActivateReverbZone());

    
        }

    }
    IEnumerator ActivateReverbZone()
    {
        if (!audioReverbZone.enabled)
        {
            audioReverbZone.enabled = true;
            PPvolume.enabled = true;

            yield return new WaitForSeconds(5f);
            audioReverbZone.enabled = false;
            PPvolume.enabled = false;
        }
        else
        {
            yield return null;
        }
    }
}
