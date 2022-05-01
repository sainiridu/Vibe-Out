using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public AudioReverbZone audioReverbZone;

    private ScoreManager scoreManager;
    void Start()
    {
        audioReverbZone = GetComponent<AudioReverbZone>();
        scoreManager = FindObjectOfType<ScoreManager>();

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.CompareTag("Player"))
        {
            audioReverbZone.enabled = true;

            scoreManager.ObstacleHit();
        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.transform.CompareTag("Player"))
        {
            audioReverbZone.enabled = false;

            //scoreManager.ObstacleHit();
        }
    }
}
