using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject m_Blue_Particle_Prefab;
    public GameObject m_Red_Particle_Prefab;

    [HideInInspector] public ScoreManager scoreManager;


    private InstantiateObjects instantiateObjects;


    void Start()
    {
        StartCoroutine(FindScoreManager());
        instantiateObjects = FindObjectOfType<InstantiateObjects>();

    }




    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("BlueCube"))
        {
            GameObject blueParticle = Instantiate(m_Blue_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(blueParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 3));


            if (gameObject.CompareTag("BlueSaber"))
            {
                scoreManager.CorrectColorCube();
            }

            else if (gameObject.CompareTag("RedSaber"))
            {
                scoreManager.WrongColorCube();
            }

        }
        else if (other.gameObject.CompareTag("RedCube"))
        {
            GameObject redParticle = Instantiate(m_Red_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(redParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 3));


            if (gameObject.CompareTag("RedSaber"))
            {
                scoreManager.CorrectColorCube();
            }

            else if (gameObject.CompareTag("BlueSaber"))
            {
                scoreManager.WrongColorCube();
            }
        }
    }


    public IEnumerator FindScoreManager()
    {
        yield return new WaitForSeconds(3.5f);
        scoreManager = FindObjectOfType<ScoreManager>();

    }
}
