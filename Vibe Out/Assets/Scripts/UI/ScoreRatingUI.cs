using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRatingUI : MonoBehaviour
{
    [SerializeField] private GameObject textObject;

    private Animator animator;


    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public IEnumerator ShowScoreRating(string ratingText, Color textColor)
    {
        animator.SetBool("show", true);
        TextMeshProUGUI text = textObject.GetComponent<TextMeshProUGUI>();

        text.color = textColor;
        text.text = ratingText;

        yield return new WaitForSeconds(0.5f);
        animator.SetBool("show", false);
    }
}
