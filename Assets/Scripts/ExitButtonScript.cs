using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonScript : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadStory()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadStory1()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadStory2()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadScene7()
    {
        SceneManager.LoadScene(7);
    }
    public void LoadScene8()
    {
        SceneManager.LoadScene(8);
    }
}
