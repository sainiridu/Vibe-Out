using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    public GameObject m_Blue_Particle_Prefab;
    public GameObject m_Red_Particle_Prefab;
    private Vector3 previousePos;

    private InstantiateObjects instantiateObjects;
    private SliceSoundManager sliceSoundManager;
   
    [HideInInspector] public ScoreManager scoreManager;




    void Start()
    {
        sliceSoundManager = FindObjectOfType<SliceSoundManager>();
        scoreManager = FindObjectOfType<ScoreManager>();
        //StartCoroutine(FindScoreManager());
        instantiateObjects = FindObjectOfType<InstantiateObjects>();

    }



    void Update()
    {
        previousePos = transform.position;

    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("BlueCube"))
        {

            sliceSoundManager.PlaySliceSound();

            GameObject blueParticle = Instantiate(m_Blue_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(blueParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 3));


            if (gameObject.CompareTag("BlueSaber"))
            {
                if (Vector3.Angle(transform.position - previousePos, other.transform.up) > 120 || Vector3.Angle(transform.position - previousePos, -other.transform.up) > 120)
                {
                    scoreManager.CorrectColorCube();

                }

                else
                {
                    scoreManager.WrongDirectionHit();
                }
            }

            else if (gameObject.CompareTag("RedSaber"))
            {
                if (Vector3.Angle(transform.position - previousePos, other.transform.up) > 120 || Vector3.Angle(transform.position - previousePos, -other.transform.up) > 120)
                {
                    scoreManager.WrongColorCube();
                }
                else
                {
                    scoreManager.WrongDirectionHit();
                }
            }

        }
        else if (other.gameObject.CompareTag("RedCube"))
        {
            sliceSoundManager.PlaySliceSound();

            GameObject redParticle = Instantiate(m_Red_Particle_Prefab, other.transform.position, Quaternion.identity, instantiateObjects.transform);

            Destroy(redParticle, 2f);

            Destroy(other.transform.parent.gameObject);

            scoreManager.animator.SetInteger("rand", Random.Range(-2, 3));


            if (gameObject.CompareTag("RedSaber"))
            {
                if (Vector3.Angle(transform.position - previousePos, other.transform.up) > 120 || Vector3.Angle(transform.position - previousePos, -other.transform.up) > 120)
                {
                    scoreManager.CorrectColorCube();
                }

                else
                {
                    scoreManager.WrongDirectionHit();
                }
            }

            else if (gameObject.CompareTag("BlueSaber"))
            {
                if (Vector3.Angle(transform.position - previousePos, other.transform.up) > 120 || Vector3.Angle(transform.position - previousePos, -other.transform.up) > 120)
                {
                    scoreManager.WrongColorCube();
                }
                else
                {
                    scoreManager.WrongDirectionHit();
                }
            }

        }

    }

    public IEnumerator FindScoreManager()
    {
        yield return new WaitForSeconds(3.5f);
        scoreManager = FindObjectOfType<ScoreManager>();

    }
}
