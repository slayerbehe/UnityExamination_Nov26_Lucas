using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject SettingsPanel;
    private bool SettingsOpen;

    // Update is called once per frame
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
