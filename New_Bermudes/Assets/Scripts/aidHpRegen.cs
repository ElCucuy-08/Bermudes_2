using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aidHpRegen : MonoBehaviour
{
    public PlayerHealth health;
    public GameObject aid;
    void Start()
    {
        
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            health.currentHealth += 30;
            aid.SetActive(false);
        }
    }

}
