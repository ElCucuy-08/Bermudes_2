using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHPSystem : MonoBehaviour
{
    double cooldown = 0;
    public PlayerHealth health;
    private void OnTriggerStay(Collider other)
    {
        cooldown = cooldown - Time.deltaTime;
        if(cooldown<=0)
        {
            health.currentHealth -= 5;
            cooldown = 1;
        }    
    }
}
