using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScoresCanvas : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI[] scoreTexts;
    [SerializeField] private TextMeshProUGUI highScoreText;



    void Awake()
    {
        foreach (TextMeshProUGUI scoreNum in scoreTexts)
        {
            scoreNum.text = Getint(scoreNum.transform.name).ToString();

            if (Getint("HighScore") < Getint(scoreNum.transform.name))
            {
                SetInt("HighScore", Getint(scoreNum.transform.name));
            }
        }

        highScoreText.text = Getint("HighScore").ToString();
    }


    public void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public int Getint(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName, 0);
    }
}
