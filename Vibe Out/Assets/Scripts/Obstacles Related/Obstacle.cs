using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public AudioReverbZone audioReverbZone;

    private ScoreManager scoreManager;
    void Start()
    {
        audioReverbZone = transform.GetComponentInParent<AudioReverbZone>();
        scoreManager = FindObjectOfType<ScoreManager>();

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player"))
        {
            StartCoroutine(ActivateReverbZone());

            scoreManager.ObstacleHit();
        }

    }
    IEnumerator ActivateReverbZone()
    {
        if (!audioReverbZone.enabled)
        {
            audioReverbZone.enabled = true;

            yield return new WaitForSeconds(5f);
            audioReverbZone.enabled = false;
        }
        else
        {
            yield return null;
        }
    }
}
