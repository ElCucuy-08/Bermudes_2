using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public PlayerHealth hp;
    void Start()
    {
        cam1.gameObject.SetActive(false);
    }

    void Update()
    {
        if(hp.currentHealth <= 0f)
        {
            SceneManager.LoadScene(4);
        }
    }
}
