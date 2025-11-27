using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BEGIN : MonoBehaviour
{
    [SerializeField] Text Text;
    void Start()
    {
        Text.gameObject.SetActive(true);
    }

    
    void Update()
    {
        if(Text.isActiveAndEnabled == true)
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Text.gameObject.SetActive(false);
            }
        }
    }
}
