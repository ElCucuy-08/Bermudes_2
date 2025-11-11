using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aidHpRegen : MonoBehaviour
{
    public Slider hp;
    public float hpRegen = 30f;
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
            hp.value += hpRegen;
            aid.SetActive(false);
        }
    }

}
