using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int totalSpawns;
    public int currentScore;

    public TextMeshProUGUI scoreText;

    [HideInInspector] public Animator animator;

    void Start()
    {
        animator = scoreText.transform.parent.GetComponent<Animator>();
    }

    void Update()
    {
        scoreText.text = currentScore.ToString();
    }


    public void MissedCube()
    {
        if (currentScore - 50 >= 0)
        {
            currentScore -= 50;
        }
        else
        {
            currentScore = 0;
        }
    }

    public void CorrectColorCube()
    {
        currentScore += 50;
    }

    public void WrongColorCube()
    {
        currentScore += 20;
    }
    public void WrongDirectionHit()
    {
        if (currentScore - 20 >= 0)
        {
            currentScore -= 20;
        }
        else
        {
            currentScore = 0;
        }
    }
}
