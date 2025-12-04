using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorTrigger : MonoBehaviour
{
    [Header("Монстры (префабы)")]
    public List<GameObject> monsters; // Список префабов монстров

    [Header("Настройки тряски камеры")]
    public float shakeDuration = 0.5f; // Длительность тряски
    public float shakeMagnitude = 0.2f; // Сила тряски

    [Header("Настройки урона")]
    public int damageAmount = 10; // Количество урона

    [Header("Другие параметры")]
    public Transform spawnPoint; // Точка появления монстра (если не задана, используется позиция триггера)

    private Camera mainCamera; // Ссылка на основную камеру
    private bool isTriggered = false; // Флаг для предотвращения многократного срабатывания

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isTriggered) return; // Если уже сработало — игнорируем

        if (other.CompareTag("Player")) // Проверяем, что вошёл игрок
        {
            isTriggered = true;
            int randomAction = Random.Range(0, 3); // 0, 1 или 2 (3 варианта действий)

            switch (randomAction)
            {
                case 0:
                    SpawnRandomMonster();
                    break;
                case 1:
                    StartCoroutine(CameraShake.Shake(shakeDuration, shakeMagnitude));
                    break;
                case 2:
                    other.GetComponent<PlayerHealth>().TakeDamage(damageAmount); // Предполагается, что у игрока есть скрипт PlayerHealth
                    break;
            }
        }
    }

    // Метод для появления случайного монстра
    private void SpawnRandomMonster()
    {
        if (monsters.Count == 0)
        {
            Debug.LogWarning("Список монстров пуст!");
            return;
        }

        GameObject monsterPrefab = monsters[Random.Range(0, monsters.Count)];
        Vector3 spawnPosition = spawnPoint != null ? spawnPoint.position : transform.position;
        Instantiate(monsterPrefab, spawnPosition, Quaternion.identity);
    }
}
