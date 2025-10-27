using UnityEngine;
using UnityEngine.UI;
public class Bars : MonoBehaviour
{

    public Image myImage; // Перетащите сюда компонент Image из инспектора
    public float targetFillAmount = 0.5f; // Значение от 0 до 1

    void Start()
    {
        if (myImage == null)
        {
            myImage = GetComponent<Image>();
        }
    }

    void Update()
    {
        // Пример: постепенное изменение fillAmount
        if (myImage != null && myImage.fillAmount != targetFillAmount)
        {
            myImage.fillAmount = Mathf.Lerp(myImage.fillAmount, targetFillAmount, Time.deltaTime);
        }
    }

    // Пример метода для установки значения
    public void SetFillAmount(float amount)
    {
        targetFillAmount = Mathf.Clamp01(amount);
    }
}
