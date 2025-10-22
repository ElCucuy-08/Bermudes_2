using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuESC : MonoBehaviour
{ 
    // �������� �����, ������� ����� ���������
    public string sceneName = "YourSceneName";

    void Update()
    {
        // ��������� ������� ������� P
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        // ��������� ����� �� �����
        SceneManager.LoadScene(sceneName);
    }
}
