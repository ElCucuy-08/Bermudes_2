using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAtack : MonoBehaviour
{
    public Transform player; // Ссылка на игрока
    public float attackRadius = 10f; // Радиус, в котором монстр атакует
    public float attackCooldown = 2f; // Задержка между атаками
    private bool canAttack = true;

    void Update()
    {
        // Проверяем расстояние до игрока
        if (Vector3.Distance(transform.position, player.position) <= attackRadius)
        {
            if (canAttack)
            {
                Attack();
                canAttack = false;
                Invoke(nameof(ResetAttack), attackCooldown);
            }
        }
    }

    void Attack()
    {
        Debug.Log("Монстр атакует игрока!");
        // Здесь можно добавить логику атаки: наносить урон, воспроизводить анимацию и т.д.
    }

    void ResetAttack()
    {
        canAttack = true;
    }

}
