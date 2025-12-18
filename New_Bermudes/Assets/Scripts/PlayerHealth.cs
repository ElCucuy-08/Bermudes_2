using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100;
    public Slider slider;

    public void Update()
    {
        slider.value = currentHealth;
        if (currentHealth > 100)
        {
            currentHealth = 100;
        }
        else if (currentHealth < 1)
        {
            Die();
        }
    }
    private void Die(int index = 0)
    {
        SceneManager.LoadScene(index);
    }

}
