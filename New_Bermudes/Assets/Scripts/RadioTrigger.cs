using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // Автоматически добавляет AudioSource, если его нет
public class RadioTrigger : MonoBehaviour
{
    [Header("Настройки музыки")]
    public List<AudioClip> musicTracks; // Список треков для случайного воспроизведения
    public bool playRandomTrack = true; // Воспроизводить случайный трек?
    [Range(0f, 1f)] public float volume = 0.5f; // Громкость

    private AudioSource audioSource;
    private bool isPlaying = false;
    private GameObject currentRadio; // Текущее радио, с которым взаимодействуем

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // Добавляем AudioSource на игрока
        audioSource.volume = volume;
        audioSource.loop = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, в который вошли, имеет тег "Radio" и музыка ещё не играет
        if (other.CompareTag("Radio") && !isPlaying)
        {
            PlayMusic();
            isPlaying = true;
            currentRadio = other.gameObject; // Запоминаем текущее радио
            Debug.Log($"Игрок вошёл в зону радио: {other.name}. Воспроизводится музыка.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Проверяем, что вышли из зоны текущего радио
        if (other.gameObject == currentRadio && isPlaying)
        {
            StopMusic();
            isPlaying = false;
            currentRadio = null;
            Debug.Log("Игрок вышел из зоны радио. Музыка остановлена.");
        }
    }

    private void PlayMusic()
    {
        if (musicTracks.Count == 0)
        {
            Debug.LogWarning("Список треков пуст! Добавьте AudioClip в инспекторе.");
            return;
        }

        AudioClip trackToPlay = playRandomTrack
            ? musicTracks[Random.Range(0, musicTracks.Count)]
            : musicTracks[0];

        audioSource.clip = trackToPlay;
        audioSource.Play();
    }

    private void StopMusic()
    {
        audioSource.Stop();
    }
}
