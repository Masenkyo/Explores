using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }public void GoToDeath()
    {
        SceneManager.LoadScene("Death");
    }public void GoToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
