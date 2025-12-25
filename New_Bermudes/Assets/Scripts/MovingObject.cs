using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    private Transform[] waypoints;
    private float speed;
    private int currentIndex = 0;
    private bool isMoving = false;
    private System.Action onFinished;

    // Метод для запуска движения, вызывается контроллером
    public void StartMoving(Transform[] path, float moveSpeed, System.Action callback)
    {
        waypoints = path;
        speed = moveSpeed;
        onFinished = callback;
        currentIndex = 0;
        isMoving = true;
    }

    void Update()
    {
        if (!isMoving || waypoints == null || currentIndex >= waypoints.Length) return;

        Transform target = waypoints[currentIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        Vector3 direction = target.position - transform.position;
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * 5f);
        }

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            currentIndex++;
            if (currentIndex >= waypoints.Length)
            {
                isMoving = false;
                onFinished?.Invoke(); // Сообщаем контроллеру, что приехали
            }
        }
    }
}
