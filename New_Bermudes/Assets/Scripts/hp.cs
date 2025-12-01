using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour
{
    public PlayerHealth health;
    public Slider hpBar;
    void Start()
    {
        
    }

    void Update()
    {
        
        if(health.currentHealth > 100)
        {
            health.currentHealth = 100;
        }
        else
        {
            health.Die();
        }
    }
    public void OnTriggerEnter(Collider other)
    {                 
        if(other.gameObject.tag == "Player")
        {
            health.currentHealth -= 10;
        }
    }
}
