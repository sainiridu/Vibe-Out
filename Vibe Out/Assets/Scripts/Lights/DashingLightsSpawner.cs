using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;


public class DashingLightsSpawner : MonoBehaviour
{
    [EventID]
    public string eventID;
    public GameObject[] dashingCubes;
    public Transform[] dashingCubeSpawnTransform;

    private MusicPlayer musicPlayer;

    private float spawnOffset;
    [SerializeField] float finetuneOffset = 0;
    void Awake()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        spawnOffset = musicPlayer.audioOffset * 100 + finetuneOffset;
        Koreographer.Instance.RegisterForEvents(eventID, SpawnDashingCubes);


    }

    public void SpawnDashingCubes(KoreographyEvent evt)
    {
        int dashingCubeSpawnNum = Random.Range(0, dashingCubes.Length);
        int spawnTransformNum = Random.Range(0, dashingCubeSpawnTransform.Length);

        GameObject spawnedDashingCube = Instantiate(dashingCubes[dashingCubeSpawnNum], new Vector3(dashingCubeSpawnTransform[spawnTransformNum].position.x, dashingCubeSpawnTransform[spawnTransformNum].position.y, dashingCubeSpawnTransform[spawnTransformNum].position.z - spawnOffset), Quaternion.identity, this.transform);



    }
}
