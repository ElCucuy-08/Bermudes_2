using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuESC : MonoBehaviour
{ 
    // Название сцены, которую нужно загрузить
    public string sceneName = "YourSceneName";

    void Update()
    {
        // Проверяем нажатие клавиши P
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        // Загружаем сцену по имени
        SceneManager.LoadScene(sceneName);
    }
}
