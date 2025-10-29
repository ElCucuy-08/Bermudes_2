using UnityEngine;
using UnityEngine.UI;
public class Bars : MonoBehaviour
{

    public Image[] myImages = new Image[3];  // ���������� ���� ��������� Image �� ����������
    public float targetFillAmount = 0.5f; // �������� �� 0 �� 1
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
        // ������: ����������� ��������� fillAmount
        if (myImages[indexofImage] != null && myImages[indexofImage].fillAmount != targetFillAmount)
        {
            myImages[indexofImage].fillAmount = Mathf.Lerp(myImages[indexofImage].fillAmount, targetFillAmount, Time.deltaTime);
        }
    }

    // ������ ������ ��� ��������� ��������
    public void SetFillAmount(float amount)
    {
        targetFillAmount = Mathf.Clamp01(amount);
    }
}
