using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Credits : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    public float speed = 2f;
    public int sceneIndexToLoad = 1; // Индекс сцены для загрузки

    private int currentWaypointIndex = 0;
    private bool isMoving = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isMoving = true;
        }
    }

    void Update()
    {
        if (isMoving && waypoints.Count > 0)
        {
            Transform target = waypoints[currentWaypointIndex];
            transform.position = Vector3.MoveTowards(
                transform.position,
                target.position,
                speed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                currentWaypointIndex++;
                if (currentWaypointIndex >= waypoints.Count)
                {
                    // Загружаем новую сцену
                    SceneManager.LoadScene(sceneIndexToLoad);
                }
            }
        }
    }
}
