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
    }
    void Timer()
    {
        asd += 0.2;
    }
    void Updatetime()
    {
        Timer();
        if (asd > 0&&asd<1)
        {



            Dialog1.gameObject.SetActive(false);
            Dialog2.gameObject.SetActive(true);
            
        }
        else if (asd >60&&asd<120)
        {

            Dialog2.gameObject.SetActive(false);
            Dialog3.gameObject.SetActive(true);
            


        }
        else if (asd > 120&&asd<180)
        {



            Dialog3.gameObject.SetActive(false);
            Dialog4.gameObject.SetActive(true);
            


        }
        else if (asd > 180&&asd<240)
        {



            Dialog4.gameObject.SetActive(false);
            Dialog5.gameObject.SetActive(true);
            


        }
        else if (asd>240&&asd<300)
        {



            Dialog5.gameObject.SetActive(false);
            Dialog6.gameObject.SetActive(true);
            


        }
        else if (asd > 300 && asd < 360)
        {



            Dialog6.gameObject.SetActive(false);
            Dialog7.gameObject.SetActive(true);
            


        }
        else if (asd > 360 && asd<420)
        {


            Dialog7.gameObject.SetActive(false);
            Dialog8.gameObject.SetActive(true);

            


        }
        else if (asd > 420)
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

    }
}
