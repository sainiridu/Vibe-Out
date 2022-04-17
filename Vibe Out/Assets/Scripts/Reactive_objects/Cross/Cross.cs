using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public IEnumerator ShowCross()
    {
        animator.SetBool("ScaleIn", true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("ScaleIn", false);

    }

}
