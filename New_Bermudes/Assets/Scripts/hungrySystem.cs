using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class hungrySystem : MonoBehaviour
{
    [Header("Настройки выносливости")]
    [SerializeField] private float maxStamina = 100f; // Максимальная выносливость
    [SerializeField] private float currentStamina;   // Текущая выносливость
    [SerializeField] private float staminaDrainRate = 10f; // Скорость уменьшения выносливости при беге
    [SerializeField] private float staminaRecoverRate = 5f; // Скорость восстановления выносливости
    [SerializeField] private float staminaRecoverDelay = 2f; // Задержка перед восстановлением
    public FirstPersonController FirstPersonController;
    [Header("UI")]
    //[SerializeField] private Slider staminaSlider; // Слайдер для отображения выносливости
    public float targetFillAmount = 1; // Значение от 0 до 1
    private bool isRunning = false;
    private float recoverTimer = 0f;
    public Slider Images;
    private void Start()
    {
        currentStamina = maxStamina;
        if (Images != null)
        Images.maxValue = maxStamina;
    }

    private void Update()
    {
        // Пример: если нажат Shift, персонаж бежит
        isRunning = !FirstPersonController.m_IsWalking;


        if (isRunning && currentStamina > 0)
        {
            currentStamina -= (staminaDrainRate * Time.deltaTime) / 5;
            recoverTimer = 0f;

        }
        else
        {
            if (currentStamina < maxStamina)
            {
                recoverTimer += Time.deltaTime;
                if (recoverTimer >= staminaRecoverDelay)
                {
                    //currentStamina += staminaRecoverRate * Time.deltaTime;
                }
            }
        }

        // Ограничиваем выносливость в диапазоне [0, maxStamina]
        currentStamina = Mathf.Clamp(currentStamina, 0f, maxStamina);

        Images.value = currentStamina;
    }

    // Метод для проверки, можно ли бежать
    public bool CanRun()
    {
        return currentStamina > 0f;
    }
}
