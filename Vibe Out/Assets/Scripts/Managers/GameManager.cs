using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI countDown;
    public GameObject startMusicAndSpawn;

    public GameObject levelObjects;

    void Start()
    {
        StartCoroutine(GameStarted());
    }

    IEnumerator GameStarted()
    {
        yield return new WaitForSeconds(1f);
        countDown.text = "2";

        yield return new WaitForSeconds(1f);
        countDown.text = "1";


        yield return new WaitForSeconds(1f);
        levelObjects.SetActive(true);
        startMusicAndSpawn.SetActive(true);
        countDown.text = "GO";

        yield return new WaitForSeconds(1f);
        countDown.transform.parent.gameObject.SetActive(false);

    }
}
