using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; // Обязательно добавьте это пространство имен для работы с UI

public class SettingOn : MonoBehaviour
{
    // Публичное поле для перетаскивания целевого объекта через Инспектор
    public GameObject MainMenuSetting;
    public GameObject MainMenu;

    // Публичный метод, который будет вызываться при нажатии кнопки
    public void ActivateObject()
    {
        // Включаем или выключаем объект (переключаем его состояние активности)
        if (MainMenuSetting != null)
        {
            // Устанавливаем объект активным (true)
            MainMenuSetting.SetActive(true);
            MainMenu.SetActive(false);
            // Если вы хотите переключать состояние (включить/выключить), 
            // используйте следующую строку вместо предыдущей:
            // objectToActivate.SetActive(!objectToActivate.activeSelf); 
        }
    }
}