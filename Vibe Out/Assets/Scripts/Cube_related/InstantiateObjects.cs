using System.Collections;
using UnityEngine;
using SonicBloom.Koreo;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject[] Object_Prefabs;
    public Transform[] spawn_Transform;
    public Transform[] spawn_Transform_Right;
    public Transform[] spawn_Transform_Left;

    public float[] spawn_Rotation;


    [EventID]
    public string eventID;




    private bool spawnRight = false;
    private bool spawnLeft = false;





    void Awake()
    {
        Koreographer.Instance.RegisterForEvents(eventID, spawnObjects);

    }



    public void spawnObjects(KoreographyEvent evt)
    {
        //Spawn Cubes Randomly
        int random_Object_Select = Random.Range(0, Object_Prefabs.Length);

        int random_Location_Select = Random.Range(0, spawn_Transform.Length);

        int random_Right_Location_Select = Random.Range(0, spawn_Transform_Right.Length);

        int random_Left_Location_Select = Random.Range(0, spawn_Transform_Left.Length);

        int random_Rotation_Select = Random.Range(0, spawn_Rotation.Length);

        int spawnColorProbability = Random.Range(0, 100);

        if (spawnColorProbability > 5)
        {
            if (Object_Prefabs[random_Object_Select].transform.CompareTag("BlueCube"))
            {
                spawnRight = true;
                spawnLeft = false;
            }
            else if (Object_Prefabs[random_Object_Select].transform.CompareTag("RedCube"))
            {
                spawnLeft = true;
                spawnRight = false;
            }
        }
        else
        {
            spawnRight = true;
            spawnLeft = true;
        }



        if (spawnRight && !spawnLeft)
        {
            GameObject spawnedCube = Instantiate(Object_Prefabs[random_Object_Select], spawn_Transform_Right[random_Right_Location_Select].position, Quaternion.identity, this.transform);


            spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


            spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }

        else if (!spawnRight && spawnLeft)
        {
            GameObject spawnedCube = Instantiate(Object_Prefabs[random_Object_Select], spawn_Transform_Left[random_Left_Location_Select].position, Quaternion.identity, this.transform);


            spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


            spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);

        }

        else if (spawnLeft && spawnRight)
        {
            GameObject spawnedCube = Instantiate(Object_Prefabs[random_Object_Select], spawn_Transform[random_Location_Select].position, Quaternion.identity, this.transform);


            spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


            spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }


        spawnRight = false;
        spawnLeft = false;




    }


}
