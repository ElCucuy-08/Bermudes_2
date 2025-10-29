using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100;
    public Bars bar;
    public int addXP = 3;
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"Игрок получил {damage} урона! Осталось HP: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
        bar.SetFillAmount(currentHealth);
    }

    private void Die(int index = 0)
    {
        SceneManager.LoadScene(index);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pharmacy"))
        {
            if (currentHealth != 100)
            {
                currentHealth += addXP;
                Debug.Log("Хил");
            }
        }
        else if(other.gameObject.CompareTag("monster"))
        {
            currentHealth -= 10;
            Debug.Log("монстры атакуют");
        }
    }
}
