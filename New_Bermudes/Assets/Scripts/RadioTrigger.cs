using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))] // ������������� ��������� AudioSource, ���� ��� ���
public class RadioTrigger : MonoBehaviour
{
    [Header("��������� ������")]
    public List<AudioClip> musicTracks; // ������ ������ ��� ���������� ���������������
    public bool playRandomTrack = true; // �������������� ��������� ����?
    [Range(0f, 1f)] public float volume = 0.5f; // ���������

    private AudioSource audioSource;
    private bool isPlaying = false;
    private GameObject currentRadio; // ������� �����, � ������� ���������������

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>(); // ��������� AudioSource �� ������
        audioSource.volume = volume;
        audioSource.loop = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������, � ������� �����, ����� ��� "Radio" � ������ ��� �� ������
        if (other.CompareTag("Radio") && !isPlaying)
        {
            PlayMusic();
            isPlaying = true;
            currentRadio = other.gameObject; // ���������� ������� �����
            Debug.Log($"����� ����� � ���� �����: {other.name}. ��������������� ������.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // ���������, ��� ����� �� ���� �������� �����
        if (other.gameObject == currentRadio && isPlaying)
        {
            StopMusic();
            isPlaying = false;
            currentRadio = null;
            Debug.Log("����� ����� �� ���� �����. ������ �����������.");
        }
    }

    private void PlayMusic()
    {
        if (musicTracks.Count == 0)
        {
            Debug.LogWarning("������ ������ ����! �������� AudioClip � ����������.");
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
