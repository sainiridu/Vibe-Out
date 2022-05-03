using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class SpawnObstacle : MonoBehaviour
{
    [EventID]
    public string eventID;

    [SerializeField]private GameObject[] spawnObject;
    [SerializeField]private Transform[] spawnPosition;


    void Awake()
    {
        Koreographer.Instance.RegisterForEvents(eventID, SpawnObstacles);
    }

    public void SpawnObstacles(KoreographyEvent evt)
    {
        int random_Object_Select = Random.Range(0, spawnObject.Length);

        int random_Position_Select = Random.Range(0, spawnPosition.Length);

        GameObject obstacle = Instantiate(spawnObject[random_Object_Select], spawnPosition[random_Position_Select].position, Quaternion.identity, this.transform);
    }
}
