using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAtack : MonoBehaviour
{
    public Transform player; // ������ �� ������
    public float attackRadius = 10f; // ������, � ������� ������ �������
    public float attackCooldown = 2f; // �������� ����� �������
    private bool canAttack = true;

    void Update()
    {
        // ��������� ���������� �� ������
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
        Debug.Log("������ ������� ������!");
        // ����� ����� �������� ������ �����: �������� ����, �������������� �������� � �.�.
    }

    void ResetAttack()
    {
        canAttack = true;
    }

}
