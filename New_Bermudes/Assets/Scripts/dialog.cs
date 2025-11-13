using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Text Dialog1;
    [SerializeField] Text Dialog2;
    [SerializeField] Text Dialog3;
    [SerializeField] Text Dialog4;
    [SerializeField] Text Dialog5;
    [SerializeField] Text Dialog6;
    [SerializeField] Text Dialog7;
    [SerializeField] Text Dialog8;
    
    private void Start()
    {
        
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(false);
        Dialog3.gameObject.SetActive(false);
        Dialog4.gameObject.SetActive(false);
        Dialog5.gameObject.SetActive(false);
        Dialog6.gameObject.SetActive(false);
        Dialog7.gameObject.SetActive(false);
        Dialog8.gameObject.SetActive(false);
    }
    void Dialog2g()
    {
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog3g();
            }
        }
    }
    void Dialog3g()
    {
        Dialog2.gameObject.SetActive(false);
        Dialog3.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog4g();
            }
        }
    }
    void Dialog4g()
    {
        Dialog3.gameObject.SetActive(false);
        Dialog4.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog5g();
            }
        }
    }
    void Dialog5g()
    {
        Dialog4.gameObject.SetActive(false);
        Dialog5.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog6g();
            }
        }
    }
    void Dialog6g()
    {
        Dialog5.gameObject.SetActive(false);
        Dialog6.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog7g();
            }
        }
    }
    void Dialog7g()
    {
        Dialog6.gameObject.SetActive(false);
        Dialog7.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog8g();
            }
        }
    }
    void Dialog8g()
    {
        Dialog7.gameObject.SetActive(false);
        Dialog8.gameObject.SetActive(true);
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog8.gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        string idf = "Babka";
        if (other.CompareTag(idf))
        {
            Dialog1.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Dialog2g();
                idf = "Bab";
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Dialog1.gameObject.SetActive(false);
        
    }
}
