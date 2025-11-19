using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aidHpRegen : MonoBehaviour
{
    public hp hp;
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
            hp.health += 30f;
            aid.SetActive(false);
        }
    }

}
