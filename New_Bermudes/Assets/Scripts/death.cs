using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public hp hp;
    void Start()
    {
        cam1.gameObject.SetActive(false);
    }

    void Update()
    {
        if(hp.health <= 0f)
        {
            SceneManager.LoadScene(4);
        }
    }
}
