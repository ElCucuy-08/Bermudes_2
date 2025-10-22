using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Progress;

public class inventory : MonoBehaviour
{
    // ���������
    public List<GameObject> inventoryItems = new List<GameObject>();
    public int maxItems = 6;
    public float pickUpRange = 2f;
    public KeyCode pickUpKey = KeyCode.F;

    // ��������� ���������
    public Transform holdPosition;
    public GameObject objectToHide;
    private GameObject currentHeldItem;

    void Update()
    {
        // ������ ���������
        if (Input.GetKeyDown(pickUpKey))
        {
            TryPickUpItem();
        }

        // ��������� ��������� �� ��������� (1-5)
        for (int i = 0; i < 5; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i) && i < inventoryItems.Count)
            {
                SpawnItem(i);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && objectToHide != null)
        {
            RemoveCurrentItem();
        }
    }

    void TryPickUpItem()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickUpRange);
        foreach (Collider collider in hitColliders)
        {
            if (collider.CompareTag("Fruit") && inventoryItems.Count < maxItems)
            {
                GameObject item = collider.gameObject;
                inventoryItems.Add(item); // ��������� � ����� ������
                item.SetActive(false);
                Debug.Log("�������� �������: " + item.name + " (� ����� " + inventoryItems.Count + ")");
                break;
            }
            else if (collider.CompareTag("madical") && inventoryItems.Count < maxItems)
            {
                GameObject item = collider.gameObject;
                inventoryItems.Add(item); // ��������� � ����� ������
                item.SetActive(false);
                Debug.Log("�������� �������: " + item.name + " (� ����� " + inventoryItems.Count + ")");
                break;
            }
        }
        
    }


    void SpawnItem(int index)
    {
        if (currentHeldItem != null)
        {
            Destroy(currentHeldItem);
        }

        if (index < inventoryItems.Count)
        {
            GameObject itemPrefab = inventoryItems[index];
            currentHeldItem = Instantiate(itemPrefab,  holdPosition.position,  holdPosition.rotation,  holdPosition  );
            Debug.Log("�������� ������� �� ����� " + (index + 1) + ": " + itemPrefab.name);
            currentHeldItem.SetActive(true);
        }
        objectToHide.SetActive(true );
    }

    void RemoveCurrentItem()
    {
        if (currentHeldItem == null) return;

        // ������� � ������� ������ �� ���������
        for (int i = 0; i < inventoryItems.Count; i++)
        {
            if (inventoryItems[i].name + "(Clone)" == currentHeldItem.name)
            {
                inventoryItems.RemoveAt(i);
                Debug.Log("������ ������� �� ����� " + (i + 1) + ": " + currentHeldItem.name);
                break;
            }
        }

        Destroy(currentHeldItem);
        currentHeldItem = null;
    }
}
