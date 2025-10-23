using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            cam2.SetActive(false);
            cam1.SetActive(true);
        }
    }
}
