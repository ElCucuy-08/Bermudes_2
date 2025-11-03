using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_1 : MonoBehaviour
{
    public List<Transform> points; // Список точек, по которым будет двигаться объект
    public float speed = 2f;      // Скорость движения
    //private string targetTag = "Player"; // Тег игрока

    private int currentPointIndex = 0;
    //private bool isMoving = false;
    //private Transform playerTransform;

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag(targetTag))
    //    {
    //        isMoving = true;
    //        playerTransform = other.transform;
    //    }
    //}

    void Update()
    {
        if (/*isMoving && */points.Count > 0)
        {
            // Двигаем объект по точкам
            Transform targetPoint = points[currentPointIndex];
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

            //// Двигаем игрока вместе с объектом
            //if (playerTransform != null)
            //{
            //    Vector3 offset = playerTransform.position - transform.position;
            //    playerTransform.position = transform.position + offset;
            //}

            // Если достигли точки, переходим к следующей
            if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                currentPointIndex = (currentPointIndex + 1) % points.Count;
            }
        }
    }
}
