using System.Collections;
using UnityEngine;
using SonicBloom.Koreo;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] Object_Prefabs;
    public Transform[] spawn_Transform;
    public Transform[] spawn_Transform_Right;
    public Transform[] spawn_Transform_Left;

    public float[] spawn_Rotation;


    [EventID]
    public string eventID;
    public ScoreManager scoreManager;
    private bool spawnRight = false;
    private bool spawnLeft = false;





    void Awake()
    {
        Koreographer.Instance.RegisterForEvents(eventID, spawnObjects);
    }



    public void spawnObjects(KoreographyEvent evt)
    {

        int objectDetailsNum = evt.GetIntValue();
        int spawn_Object;
        int spawn_Location;
        int random_Rotation_Select = Random.Range(0, spawn_Rotation.Length);

        //Spawn Cubes Randomly

        if (objectDetailsNum >= 01 && objectDetailsNum < 100)
        {

            if (Object_Prefabs[objectDetailsNum / 10] != null)
            {
                spawn_Object = objectDetailsNum / 10;
            }
            else
            {
                spawn_Object = Random.Range(0, Object_Prefabs.Length);
            }
            if (spawn_Transform[objectDetailsNum % 10] != null)
            {
                spawn_Location = objectDetailsNum % 10;
            }
            else
            {
                spawn_Location = Random.Range(0, spawn_Transform.Length);
            }

            GameObject spawnedCube = Instantiate(Object_Prefabs[spawn_Object], spawn_Transform_Right[spawn_Location].position, Quaternion.identity, this.transform);


            spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


            spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
        }

        else if (objectDetailsNum > 100 && objectDetailsNum < 200)
        {

            for (int i = 0; i < Object_Prefabs.Length; i++)
            {

                // GameObject spawnedCube = Instantiate(Object_Prefabs[0], spawn_Transform_Right[spawn_Location].position, Quaternion.identity, this.transform);


                // spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


                // spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
            }
        }


    }


}
