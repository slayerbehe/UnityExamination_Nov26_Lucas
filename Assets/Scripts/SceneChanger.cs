using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public void SwapToStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void SwapToFirstScene()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    
    public void SwapToSecondScene()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
