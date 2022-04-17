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
        if (currentScore - 15 >= 0)
        {
            currentScore -= 15;
        }
        else
        {
            currentScore = 0;
        }
    }

    public void CorrectColorCube()
    {
        currentScore += 25;
    }

    public void WrongColorCube()
    {
        currentScore += 10;
    }
}
