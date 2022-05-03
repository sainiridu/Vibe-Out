using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExtraCubes : MonoBehaviour
{

    public int missedCubes = 0;
    private ScoreManager scoreManager;

    void Start()
    {

        scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedCube") || other.gameObject.CompareTag("BlueCube"))
        {
            scoreManager.MissedCube();

            Destroy(other.transform.parent.gameObject, 2.5f);
            missedCubes++;
        }

        else if (other.gameObject.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject, 5f);
        }
    }
}
