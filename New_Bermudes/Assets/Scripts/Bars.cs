using UnityEngine;
using UnityEngine.UI;
public class Bars : MonoBehaviour
{

    public Image myImage; // ���������� ���� ��������� Image �� ����������
    public float targetFillAmount = 0.5f; // �������� �� 0 �� 1

    void Start()
    {
        if (myImage == null)
        {
            myImage = GetComponent<Image>();
        }
    }

    void Update()
    {
        // ������: ����������� ��������� fillAmount
        if (myImage != null && myImage.fillAmount != targetFillAmount)
        {
            myImage.fillAmount = Mathf.Lerp(myImage.fillAmount, targetFillAmount, Time.deltaTime);
        }
    }

    // ������ ������ ��� ��������� ��������
    public void SetFillAmount(float amount)
    {
        targetFillAmount = Mathf.Clamp01(amount);
    }
}
