using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MainMenuSetting;
    public GameObject MainMenuCredits;
    public GameObject MainMenuAbout;

    public void SettingON()
    {
        if (MainMenuSetting != null)
        {
            MainMenuSetting.SetActive(true);
            MainMenu.SetActive(false);
        }
    }
    public void SettingOFF()
    {
        if (MainMenuSetting != null)
        {
            MainMenuSetting.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
    public void CreditsON()
    {
        if (MainMenuCredits != null)
        {
            MainMenuCredits.SetActive(true);
            MainMenu.SetActive(false);
        }
    }
    public void CreditsOFF()
    {
        if (MainMenuCredits != null)
        {
            MainMenuCredits.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
    public void AboutON()
    {
        if (MainMenuAbout != null)
        {
            MainMenuAbout.SetActive(true);
            MainMenu.SetActive(false);
        }
    }
    public void AboutOFF()
    {
        if (MainMenuAbout != null)
        {
            MainMenuAbout.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
}