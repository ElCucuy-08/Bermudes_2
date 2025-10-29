using UnityEngine;
using UnityEngine.UI;
public class Bars : MonoBehaviour
{

    public Image[] myImages = new Image[3];  // Перетащите сюда компонент Image из инспектора
    public float targetFillAmount = 0.5f; // Значение от 0 до 1
    public int indexofImage;
    void Start()
    {
        if (myImages == null)
        {
            myImages = GetComponent<Image[]>();
        }
    }

    void Update()
    {
        // Пример: постепенное изменение fillAmount
        if (myImages[indexofImage] != null && myImages[indexofImage].fillAmount != targetFillAmount)
        {
            myImages[indexofImage].fillAmount = Mathf.Lerp(myImages[indexofImage].fillAmount, targetFillAmount, Time.deltaTime);
        }
    }

    // Пример метода для установки значения
    public void SetFillAmount(float amount)
    {
        targetFillAmount = Mathf.Clamp01(amount);
    }
}
