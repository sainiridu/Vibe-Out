using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject m_Blue_Particle_Prefab;
    public GameObject m_Red_Particle_Prefab;

    public ScoreManager scoreManager;

    [HideInInspector] public int scoreToAdd;




    private void OnTriggerEnter(Collider other)
    {
        scoreToAdd = Random.Range(10, 25);
        if (other.gameObject.CompareTag("BlueCube"))
        {
            GameObject blueParticle = Instantiate(m_Blue_Particle_Prefab, other.transform.position, Quaternion.identity);

            Destroy(blueParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 2));

            scoreManager.currentScore += scoreToAdd;

        }
        else if (other.gameObject.CompareTag("RedCube"))
        {
            GameObject redParticle = Instantiate(m_Red_Particle_Prefab, other.transform.position, Quaternion.identity);

            Destroy(redParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 2));

            scoreManager.currentScore += scoreToAdd;

        }



    }
}
