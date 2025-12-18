using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] Text Dialog1;
    [SerializeField] Text Dialog2;
    [SerializeField] Text Dialog3;
    [SerializeField] Text Dialog4;
    [SerializeField] Text Dialog5;
    [SerializeField] Text Dialog6;
    [SerializeField] Text Dialog7;
    [SerializeField] Text Dialog8;
    string idf = "Babka";
    double asd = 0;

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
        audioSource.Stop();

    }
    void Timer()
    {
        asd += 0.12;
    }
    
    public void TurnOffSound()
    {
        audioSource.Stop();
    }

    
    public void TurnOnSound()
    {
        audioSource.Play();
    }

    void Updatetime()
    {
        Timer();
        
        if (asd > 0&&asd<1)
        {



            Dialog1.gameObject.SetActive(false);
            Dialog2.gameObject.SetActive(true);
            
        }
        else if (asd >65&&asd<125)
        {

            Dialog2.gameObject.SetActive(false);
            Dialog3.gameObject.SetActive(true);
            


        }
        else if (asd > 125&&asd<200)
        {



            Dialog3.gameObject.SetActive(false);
            Dialog4.gameObject.SetActive(true);
            


        }
        else if (asd > 200&&asd<228)
        {



            Dialog4.gameObject.SetActive(false);
            Dialog5.gameObject.SetActive(true);
            


        }
        else if (asd>228&&asd<270)
        {



            Dialog5.gameObject.SetActive(false);
            Dialog6.gameObject.SetActive(true);
            


        }
        else if (asd > 270 && asd < 335)
        {



            Dialog6.gameObject.SetActive(false);
            Dialog7.gameObject.SetActive(true);
            


        }
        else if (asd > 335 && asd<375)
        {


            Dialog7.gameObject.SetActive(false);
            Dialog8.gameObject.SetActive(true);

            


        }
        else if (asd > 375)
        {


            Dialog8.gameObject.SetActive(false);
            




        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Babka"))
        {
            Updatetime();
            


        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        TurnOnSound();
    }
    private void OnTriggerExit(Collider other)
    {
        Dialog1.gameObject.SetActive(false);
        Dialog2.gameObject.SetActive(false);
        Dialog3.gameObject.SetActive(false);
        Dialog4.gameObject.SetActive(false);
        Dialog5.gameObject.SetActive(false);
        Dialog6.gameObject.SetActive(false);
        Dialog7.gameObject.SetActive(false);
        Dialog8.gameObject.SetActive(false);
        asd = 0;
        TurnOffSound();
    }
}
