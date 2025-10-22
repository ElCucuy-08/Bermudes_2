using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorTrigger : MonoBehaviour
{
    [Header("������� (�������)")]
    public List<GameObject> monsters; // ������ �������� ��������

    [Header("��������� ������ ������")]
    public float shakeDuration = 0.5f; // ������������ ������
    public float shakeMagnitude = 0.2f; // ���� ������

    [Header("��������� �����")]
    public int damageAmount = 10; // ���������� �����

    [Header("������ ���������")]
    public Transform spawnPoint; // ����� ��������� ������� (���� �� ������, ������������ ������� ��������)

    private Camera mainCamera; // ������ �� �������� ������
    private bool isTriggered = false; // ���� ��� �������������� ������������� ������������

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isTriggered) return; // ���� ��� ��������� � ����������

        if (other.CompareTag("Player")) // ���������, ��� ����� �����
        {
            isTriggered = true;
            int randomAction = Random.Range(0, 3); // 0, 1 ��� 2 (3 �������� ��������)

            switch (randomAction)
            {
                case 0:
                    SpawnRandomMonster();
                    break;
                case 1:
                    StartCoroutine(CameraShake.Shake(shakeDuration, shakeMagnitude));
                    break;
                case 2:
                    other.GetComponent<PlayerHealth>().TakeDamage(damageAmount); // ��������������, ��� � ������ ���� ������ PlayerHealth
                    break;
            }
        }
    }

    // ����� ��� ��������� ���������� �������
    private void SpawnRandomMonster()
    {
        if (monsters.Count == 0)
        {
            Debug.LogWarning("������ �������� ����!");
            return;
        }

        GameObject monsterPrefab = monsters[Random.Range(0, monsters.Count)];
        Vector3 spawnPosition = spawnPoint != null ? spawnPoint.position : transform.position;
        Instantiate(monsterPrefab, spawnPosition, Quaternion.identity);
    }
}
