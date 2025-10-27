using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{


   public void SceneLoad(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
