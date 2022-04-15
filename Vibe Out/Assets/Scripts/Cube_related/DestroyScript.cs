using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject m_Blue_Particle_Prefab;
    public GameObject m_Red_Particle_Prefab;

    [HideInInspector] public ScoreManager scoreManager;

    [HideInInspector] public int scoreToAdd;

    private InstantiateObjects instantiateObjects;


    void Start()
    {
        StartCoroutine(FindScoreManager());
        instantiateObjects = FindObjectOfType<InstantiateObjects>();

    }




    private void OnTriggerEnter(Collider other)
    {
        scoreToAdd = Random.Range(10, 25);
        if (other.gameObject.CompareTag("BlueCube"))
        {
            GameObject blueParticle = Instantiate(m_Blue_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(blueParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 2));

            scoreManager.currentScore += scoreToAdd;

        }
        else if (other.gameObject.CompareTag("RedCube"))
        {
            GameObject redParticle = Instantiate(m_Red_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(redParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 2));

            scoreManager.currentScore += scoreToAdd;

        }



    }


    public IEnumerator FindScoreManager()
    {
        yield return new WaitForSeconds(3.5f);
        scoreManager = FindObjectOfType<ScoreManager>();

    }
}
