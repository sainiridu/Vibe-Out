using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CanvasControl : MonoBehaviour
{
    public void HomeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void Fool()
    {
        SceneManager.LoadScene(1);
    }

    public void PartyOnMyMind()
    {
        SceneManager.LoadScene(2);
    }

    public void Stay()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }
   
}
