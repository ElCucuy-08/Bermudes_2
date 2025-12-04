using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public float health = 100f;
    public Slider hpBar;
    void Start()
    {
        
    }

    void Update()
    {
        hpBar.value = health;
        if(health > 100f)
        {
            health = 100f;
        }
    }
    public void OnTriggerEnter(Collider other)
    {                 
        if(other.gameObject.tag == "Player")
        {
            health -= 10f;
        }
    }
}
