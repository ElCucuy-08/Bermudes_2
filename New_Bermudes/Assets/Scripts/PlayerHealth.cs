using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth = 100;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log($"����� ������� {damage} �����! �������� HP: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("����� ����!");
        // ����� ����� �������� ������ ������ (�������, ������� ������ � �.�.)
    }
}
