using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory2 : MonoBehaviour
{
    public List<GameObject> inventoryItems = new List<GameObject>();
    private int MaxItems = 6;
    public float pickUpRange = 2f;
    public KeyCode pickUpKey = KeyCode.F;

    // Картинки
    [SerializeField] private RawImage bananaImage;
    [SerializeField] private RawImage strawberryImage;
    [SerializeField] private RawImage appleImage;
    [SerializeField] private RawImage watermelonImage;
    [SerializeField] private RawImage medicalImage;
    [SerializeField] private RawImage orangeImage;

    // Появление предметов
    public Transform holdPosition;
    public GameObject objectToHide;
    private GameObject currentHeldItem;

    private void Start()
    {
        bananaImage.gameObject.SetActive(false);
        strawberryImage.gameObject.SetActive(false);
        appleImage.gameObject.SetActive(false);
        watermelonImage.gameObject.SetActive(false);
        medicalImage.gameObject.SetActive(false);
        orangeImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(pickUpKey))
        {
            TryPickUpItem();
        }
        // Проверяем нажатия клавиш 1-5 (Alpha1 - Alpha5)
        for (int i = 0; i < 5; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i) && i < inventoryItems.Count)
            {
                SpawnItem(i);
            }
        }
    }

    void TryPickUpItem()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, pickUpRange);
        foreach (Collider collider in hitColliders)
        {
            if (collider.CompareTag("banana"))
            {
                bananaImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
            else if (collider.CompareTag("orange"))
            {
                orangeImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
            else if (collider.CompareTag("watermelon"))
            {
                watermelonImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
            else if (collider.CompareTag("strawberry"))
            {
                strawberryImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
            else if (collider.CompareTag("medical"))
            {
                medicalImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
            else if (collider.CompareTag("apple"))
            {
                appleImage.gameObject.SetActive(true);
                GameObject item = collider.gameObject;
                inventoryItems.Add(item);
                item.SetActive(false);
            }
        }
    }

    void SpawnItem(int index)
    {
        // Удаляем текущий удерживаемый предмет, если он есть
        if (currentHeldItem != null)
        {
            Destroy(currentHeldItem);
        }
        // Спавним новый предмет из инвентаря
        if (index < inventoryItems.Count)
        {
            GameObject itemPrefab = inventoryItems[index];
            currentHeldItem = Instantiate(itemPrefab, holdPosition.position, holdPosition.rotation, holdPosition);
            currentHeldItem.SetActive(true);
            Debug.Log("Появился предмет из слота " + (index + 1) + ": " + itemPrefab.name);
        }
    }
}
