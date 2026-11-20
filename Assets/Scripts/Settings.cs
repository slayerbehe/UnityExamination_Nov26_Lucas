using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject SettingsPanel;
    public bool SettingsOpen;

    public void SettingsOpenOff()
    {
        SettingsOpen = false;
    }
    public void OpenMenu()
    {
        if (!SettingsOpen)
        {
            SettingsPanel.SetActive(true);
            SettingsOpen = true;
        }
        else
        {
            SettingsPanel.SetActive(false);
            SettingsOpen = false;
        }
    }
}
