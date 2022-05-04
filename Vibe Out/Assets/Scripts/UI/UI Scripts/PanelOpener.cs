using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    public GameObject[] Panel;

    public void Stay()
    {
        if (Panel[0] != null)
        {
            // Panel[1].SetActive(false);
            // Panel[2].SetActive(false);
            // Panel[3].SetActive(false);

            foreach (GameObject gameObject in Panel)
            {
                if (gameObject != Panel[0])
                    gameObject.SetActive(false);
            }

            bool isActive = Panel[0].activeSelf;

            Panel[0].SetActive(!isActive);
        }
    }

    public void Showdown()
    {
        if (Panel[1] != null)
        {
            Panel[0].SetActive(false);
            Panel[2].SetActive(false);
            Panel[3].SetActive(false);

            bool isActive = Panel[1].activeSelf;

            Panel[1].SetActive(!isActive);
        }
    }

    public void PartyOnMyMind()
    {
        if (Panel[2] != null)
        {
            Panel[0].SetActive(false);
            Panel[1].SetActive(false);
            Panel[3].SetActive(false);

            bool isActive = Panel[2].activeSelf;

            Panel[2].SetActive(!isActive);
        }
    }

    public void WhateverItTakes()
    {
        if (Panel[3] != null)
        {
            Panel[0].SetActive(false);
            Panel[1].SetActive(false);
            Panel[2].SetActive(false);

            bool isActive = Panel[3].activeSelf;

            Panel[3].SetActive(!isActive);
        }
    }
}