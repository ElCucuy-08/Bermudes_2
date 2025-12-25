using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_Credits : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    public List<MovingObject> objectsToMove = new List<MovingObject>(); // Список объектов
    public float speed = 2f;
    public int sceneIndexToLoad = 2;

    private int objectsFinished = 0;
    private bool activated = false;

    void OnTriggerEnter(Collider other)
    {
        if (!activated && other.CompareTag("Player"))
        {
            activated = true;
            foreach (var obj in objectsToMove)
            {
                // Запускаем каждый объект
                obj.StartMoving(waypoints.ToArray(), speed, OnObjectReachedEnd);
            }
        }
    }

    void OnObjectReachedEnd()
    {
        objectsFinished++;
        // Если все объекты доехали до конца, меняем сцену
        if (objectsFinished >= objectsToMove.Count)
        {
            SceneManager.LoadScene(sceneIndexToLoad);
        }
    }
}
