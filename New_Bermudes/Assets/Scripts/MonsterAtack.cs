using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAtack : MonoBehaviour
{
    public Transform player; // ������ �� ������
    public float attackRadius = 10f; // ������, � ������� ������ �������
    public float attackCooldown = 2f; // �������� ����� �������
    private bool canAttack = true;
    public PlayerHealth health;
    void Update()
    {
        // ��������� ���������� �� ������
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
