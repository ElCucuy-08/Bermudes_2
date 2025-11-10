using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson; // Для работы с UI (например, слайдер выносливости)

public class StaminaScript : MonoBehaviour
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

    private bool isRunning = false;
    private float recoverTimer = 0f;
    public Bars bars = new Bars();
    private void Start()
    {
        //currentStamina = maxStamina;
        //if (staminaSlider != null)
        //    staminaSlider.maxValue = maxStamina;
    }

    private void Update()
    {
        // Пример: если нажат Shift, персонаж бежит
        isRunning = !FirstPersonController.m_IsWalking;
        if (currentStamina > 0)
        {
            FirstPersonController.CanRun = true;
        }
        else
        {
            FirstPersonController.CanRun = false;
        }
        if (isRunning && currentStamina > 0)
        {
            currentStamina -= staminaDrainRate * Time.deltaTime;
            recoverTimer = 0f;

        }
        else
        {
            if (currentStamina < maxStamina)
            {
                recoverTimer += Time.deltaTime;
                if (recoverTimer >= staminaRecoverDelay)
                {
                    currentStamina += staminaRecoverRate * Time.deltaTime;
                }
            }
        }

        // Ограничиваем выносливость в диапазоне [0, maxStamina]
        currentStamina = Mathf.Clamp(currentStamina, 0f, maxStamina);

        // Обновляем UI
        if (bars.targetFillAmount != 0)
            bars.indexofImage = 2;
            bars.SetFillAmount(currentStamina/100);
    }

    // Метод для проверки, можно ли бежать
    public bool CanRun()
    {
        return currentStamina > 0f;
    }
}
