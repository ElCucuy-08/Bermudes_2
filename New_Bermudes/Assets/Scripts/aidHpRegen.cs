using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aidHpRegen : MonoBehaviour
{
    public PlayerHealth hp;
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
            hp.currentHealth += 30;
            aid.SetActive(false);
        }
    }

}
