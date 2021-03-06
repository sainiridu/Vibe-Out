using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int totalSpawns;
    public int currentScore;
    public TextMeshProUGUI scoreText;
    private ScoreRatingUI scoreRatingUI;

    [HideInInspector] public Animator animator;

    void Start()
    {
        animator = scoreText.transform.parent.GetComponent<Animator>();

        scoreRatingUI = FindObjectOfType<ScoreRatingUI>();
    }

    void Update()
    {
        scoreText.text = currentScore.ToString();
    }


    public void MissedCube()
    {
        StartCoroutine(scoreRatingUI.ShowScoreRating("MISSED", new Color32(255, 0, 53, 255)));

        if (currentScore - 150 >= 0)
        {
            currentScore -= 150;
        }
        else
        {
            currentScore = 0;
        }
    }

    public void CorrectColorCube()
    {
        StartCoroutine(scoreRatingUI.ShowScoreRating("GREAT", new Color32(0, 224, 150, 255)));
        currentScore += 200;
    }

    public void WrongColorCube()
    {
        StartCoroutine(scoreRatingUI.ShowScoreRating("WRONG COLOR", new Color32(255, 255, 255, 255)));
        currentScore += 50;
    }
    public void WrongDirectionHit()
    {
        StartCoroutine(scoreRatingUI.ShowScoreRating("TRY HARDER", new Color32(255, 252, 97, 255)));
        if (currentScore - 100 >= 0)
        {
            currentScore -= 100;
        }
        else
        {
            currentScore = 0;
        }
    }

    public void ObstacleHit()
    {
        if (currentScore - 250 >= 0)
        {
            currentScore -= 250;
        }
        else
        {
            currentScore = 0;
        }
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
