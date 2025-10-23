using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public float health = 100f;
    public Slider hpBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.value = health;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            health -= 10f;
        }
    }
}
