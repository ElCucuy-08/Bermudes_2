using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OnPlay()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnExit()
    {
        Application.Quit();
    }

    public void OnSatting()
    {
        SceneManager.LoadScene("Setting");
    }
}
