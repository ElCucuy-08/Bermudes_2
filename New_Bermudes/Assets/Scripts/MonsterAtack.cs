using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAtack : MonoBehaviour
{
    public Transform player; // Ссылка на игрока
    public float attackRadius = 10f; // Радиус, в котором монстр атакует
    public float attackCooldown = 2f; // Задержка между атаками
    private bool canAttack = true;
    public PlayerHealth health;
    void Update()
    {
        // Проверяем расстояние до игрока
        if (Vector3.Distance(transform.position, player.position) <= attackRadius)
        {
            if (canAttack)
            {
               // Attack();
                canAttack = false;
                Invoke(nameof(ResetAttack), attackCooldown);
            }
        }
    }

    //void Attack()
    //{
    //    health.TakeDamage(10);
    //}

    void ResetAttack()
    {
        canAttack = true;
    }

}
