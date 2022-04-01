using System.Collections;
using UnityEngine;
using SonicBloom.Koreo;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject[] Object_Prefabs;
    public GameObject[] spawn_Locations;

    public float[] spawn_Rotation;


    [EventID]
    public string eventID;

    public ScoreManager scoreManager;
    private Transform[] spawn_Transform;




    void Awake()
    {
        Koreographer.Instance.RegisterForEvents(eventID, spawnObjects);

        spawn_Transform = new Transform[spawn_Locations.Length];

        for (int i = 0; i < spawn_Locations.Length; i++)
        {
            spawn_Transform[i] = spawn_Locations[i].transform;
        }

    }



    public void spawnObjects(KoreographyEvent evt)
    {
        //Spawn Cubes Randomly
        int random_Object_Select = Random.Range(0, Object_Prefabs.Length);

        int random_Location_Select = Random.Range(0, spawn_Transform.Length);

        int random_Rotation_Select = Random.Range(0, spawn_Rotation.Length);



        //GameObject spawnedCube = Instantiate(Object_Prefabs[random_Object_Select], spawn_Transform[random_Location_Select].position, Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]), this.transform);
        GameObject spawnedCube = Instantiate(Object_Prefabs[random_Object_Select], spawn_Transform[random_Location_Select].position, Quaternion.identity, this.transform);

        spawnedCube.transform.Find("Cube").gameObject.transform.rotation = Quaternion.Euler(0f, 0f, spawn_Rotation[random_Rotation_Select]);


        spawnedCube.transform.Find("Cube").transform.Find("SpawnLight").gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);



        //Store total number of spawned cubes
        scoreManager.totalSpawns++;




    }


}
